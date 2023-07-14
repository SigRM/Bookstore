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
    internal class DALRoles : IRolesDAL
    {
        #region CRUD : CREATE
        public  void Create(Roles pRoles)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_INSERT_Roles"); //Crear SQL Command

                    command.Parameters.AddWithValue("@id", int.Parse(pRoles.id.ToString()));
                    command.Parameters.AddWithValue("@name", pRoles.name);
                    command.Parameters.AddWithValue("@descripcion", pRoles.description);

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
        public  void Update(Roles pRoles)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_UPDATE_Roles"); //Crear SQL Command

                    command.Parameters.AddWithValue("@id", pRoles.id);
                    command.Parameters.AddWithValue("@name", pRoles.name);
                    command.Parameters.AddWithValue("@descripcion", pRoles.description);


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
                    var command = new SqlCommand("usp_UPDATE_Roles"); //Crear SQL Command

                    //Pasar parametros
                    command.Parameters.AddWithValue("@id",pID);

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
        public  Roles Read(string pId)
        {
            try
            {
                DataSet ds = null;  //Crear dataset

                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Roles_ByID "); //Crear SQL Command

                    //Pasar parametros
                    command.Parameters.AddWithValue("@id", pId);

                    //Asignar Store Procedures
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
                //Extraer la tabla
                DataTable dr = ds.Tables[0];

                //Crear objeto
                Roles oRoles = null;

                if (dr.Rows.Count > 0)
                {
                    oRoles = new Roles()
                    {
                    id = Convert.ToInt16(dr.Rows[0]["id"].ToString()),
                    name = dr.Rows[0]["name"].ToString(),
                    description = dr.Rows[0]["descripcion"].ToString()

                    };
                }
                return oRoles;
            }

            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region CRUD : READALL
        public  List<Roles> ReadAll()
        {
            try
            {
                //Crear Dataset
                DataSet ds = null;

                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Roles_All"); //Crear SQL Command

                    //Asignar Store Procedures
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
                //Crear lista
                List<Roles> lista = new List<Roles>();
                //Cargar lista con objetos segun tabla del dataset
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Roles oRoles = new Roles()
                        {
                            id = Convert.ToInt16(dr["id"].ToString()),
                            name = dr["name"].ToString(),
                            description = dr["descripcion"].ToString()

                        };
                        lista.Add(oRoles);
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
