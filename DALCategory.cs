using ProyectoV1.Entities;
using ProyectoV1.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoV1.DAL
{
    internal class DALCategory : ICategoryDAL
    {
        #region CRUD : CREATE
        public void Create(Category pCategory)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_INSERT_Category"); //Crear SQL Command

                    command.Parameters.AddWithValue("@category_id", int.Parse(pCategory.category_id.ToString()));
                    command.Parameters.AddWithValue("@category_name", pCategory.category_name);
                    command.Parameters.AddWithValue("@description", pCategory.description);

                    //Asignar Store Procedures
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message  {0}\n", er.Message);
                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region CRUD: UPDATE
        public void Update(Category pCategory)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_UPDATE_Category"); //Crear SQL Command

                    command.Parameters.AddWithValue("@category_id", pCategory.category_id);
                    command.Parameters.AddWithValue("@category_name", pCategory.category_name);
                    command.Parameters.AddWithValue("@description", pCategory.description);

                    //Asignar Store Procedures
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region CRUD: DELETE
        public void Delete(string pID)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_DELETE_Category_ByID "); //Crear SQL Command

                    //Pasar parametros
                    command.Parameters.AddWithValue("@category_id", pID);

                    //Asignar Store Procedures
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region CRUD: READ
        public Category Read(string pID)
        {
            try
            {
                DataSet ds = null;  //Crear dataset

                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Category_ByID "); //Crear SQL Command

                    //Pasar parametros
                    command.Parameters.AddWithValue("@category_id", pID);

                    //Asignar Store Procedures
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
                //Extraer la tabla
                DataTable dr = ds.Tables[0];

                //Crear objeto
                Category oCategory = null;

                if (dr.Rows.Count > 0)
                {
                    oCategory = new Category()
                    {
                    category_id = Convert.ToInt16(dr.Rows[0]["category_id"].ToString()),
                    category_name = dr.Rows[0]["category_name"].ToString(),
                    description = dr.Rows[0]["description"].ToString()

                    };
                }
                return oCategory;
            }

            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region CRUD : READALL
        public List<Category> ReadAll()
        {
            try
            {
                //Crear Dataset
                DataSet ds = null;

                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Category_All"); //Crear SQL Command

                    //Asignar Store Procedures
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
                //Crear lista
                List<Category> lista = new List<Category>();
                //Cargar lista con objetos segun tabla del dataset
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Category oCategory = new Category()
                        {
                            category_id = Convert.ToInt16(dr["category_id"].ToString()),
                            category_name = dr["category_name"].ToString(),
                            description = dr["description"].ToString()

                        };
                        lista.Add(oCategory);
                    }
                }
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
