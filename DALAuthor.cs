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
    internal class DALAuthor : IAuthorDAL
    {
        #region CRUD : CREATE
        public  void Create(Author pAuthor)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_INSERT_Author"); //Crear SQL Command

                    command.Parameters.AddWithValue("@author_id", int.Parse(pAuthor.author_id.ToString()));
                    command.Parameters.AddWithValue("@author_name", pAuthor.author_name);
                    command.Parameters.AddWithValue("@author_biography", pAuthor.author_biography);
                    command.Parameters.AddWithValue("@author_email", pAuthor.author_email);
                    command.Parameters.AddWithValue("@author_phone", pAuthor.author_phone);

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
        public  void Update(Author pAuthor)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_UPDATE_Author"); //Crear SQL Command

                    command.Parameters.AddWithValue("@author_id", pAuthor.author_id);
                    command.Parameters.AddWithValue("@author_name", pAuthor.author_name);
                    command.Parameters.AddWithValue("@author_biography", pAuthor.author_biography);
                    command.Parameters.AddWithValue("@author_email", pAuthor.author_email);
                    command.Parameters.AddWithValue("@author_phone", pAuthor.author_phone);

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
        public  void Delete(string pID)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_DELETE_Author_ByID "); //Crear SQL Command

                    //Pasar parametros
                    command.Parameters.AddWithValue("@author_id",pID);             

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
        public Author Read(string pID)
        {
            try
            {
                DataSet ds = null;  //Crear dataset

                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Author_ByID "); //Crear SQL Command

                    //Pasar parametros
                    command.Parameters.AddWithValue("@author_id", pID);

                    //Asignar Store Procedures
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
                //Extraer la tabla
                DataTable dr = ds.Tables[0];

                //Crear objeto
                Author oAuthor = null;

                if (dr.Rows.Count > 0)
                {
                    oAuthor = new Author()
                    {
                    author_id = Convert.ToInt16(dr.Rows[0]["author_id"].ToString()),
                    author_name = dr.Rows[0]["author_name"].ToString(),
                    author_biography = dr.Rows[0]["author_biography"].ToString(),
                    author_email = dr.Rows[0]["author_email"].ToString(),
                    author_phone = dr.Rows[0]["author_phone"].ToString()

                };
                }
                return oAuthor;
            }

            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region CRUD : READALL
        public  List<Author> ReadAll()
        {
            try
            {
                //Crear Dataset
                DataSet ds = null;

                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Author_All"); //Crear SQL Command

                    //Asignar Store Procedures
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
                //Crear lista
                List<Author> lista = new List<Author>();
                //Cargar lista con objetos segun tabla del dataset
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Author oAuthor = new Author()
                        {
                            author_id = Convert.ToInt16(dr["author_id"].ToString()),
                            author_name = dr["author_name"].ToString(),
                            author_biography = dr["author_biography"].ToString(),
                            author_email = dr["author_email"].ToString(),
                            author_phone = dr["author_phone"].ToString()

                        };
                        lista.Add(oAuthor);
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
