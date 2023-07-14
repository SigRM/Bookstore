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
    internal class DALCustomers : ICustomersDAL
    {
        #region CRUD : CREATE
        public void Create(Customers pCustomers)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_INSERT_Customers"); //Crear SQL Command

                    command.Parameters.AddWithValue("@customer_id", int.Parse(pCustomers.customer_id.ToString()));
                    command.Parameters.AddWithValue("@customer_name", pCustomers.customer_name);
                    command.Parameters.AddWithValue("@customer_email", pCustomers.customer_email);
                    command.Parameters.AddWithValue("@customer_phone_number", pCustomers.customer_phone_number);
                    command.Parameters.AddWithValue("@customer_address", pCustomers.customer_address);

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
        public void Update(Customers pCustomers)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_UPDATE_Customers"); //Crear SQL Command

                    command.Parameters.AddWithValue("@customer_id", int.Parse(pCustomers.customer_id.ToString()));
                    command.Parameters.AddWithValue("@customer_name", pCustomers.customer_name);
                    command.Parameters.AddWithValue("@customer_email", pCustomers.customer_email);
                    command.Parameters.AddWithValue("@customer_phone_number", pCustomers.customer_phone_number);
                    command.Parameters.AddWithValue("@customer_address", pCustomers.customer_address);

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
                    var command = new SqlCommand("usp_DELETE_Customers_ByID "); //Crear SQL Command

                    //Pasar parametros
                    command.Parameters.AddWithValue("@customer_id", pID);

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
        public Customers Read(string pID)
        {
            try
            {
                DataSet ds = null;  //Crear dataset

                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Customers_ByID "); //Crear SQL Command

                    //Pasar parametros
                    command.Parameters.AddWithValue("@customer_id", pID);

                    //Asignar Store Procedures
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
                //Extraer la tabla
                DataTable dr = ds.Tables[0];

                //Crear objeto
                Customers oCustomers = null;

                if (dr.Rows.Count > 0)
                {
                    oCustomers = new Customers()
                    {
                     customer_id = Convert.ToUInt16(dr.Rows[0]["customer_id"].ToString()),
                     customer_name = dr.Rows[0]["customer_name"].ToString(),
                     customer_email = dr.Rows[0]["customer_email"].ToString(),
                     customer_phone_number = dr.Rows[0]["customer_phone_number"].ToString(),
                     customer_address = dr.Rows[0]["customer_address"].ToString()

                    };
                }
                return oCustomers;
            }

            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region CRUD : READALL
        public List<Customers> ReadAll()
        {
            try
            {
                //Crear Dataset
                DataSet ds = null;

                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Customers_All"); //Crear SQL Command

                    //Asignar Store Procedures
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
                //Crear lista
                List<Customers> lista = new List<Customers>();
                //Cargar lista con objetos segun tabla del dataset
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Customers oCustomers = new Customers()
                        {
                        customer_id = Convert.ToInt16(dr["customer_id"].ToString()),
                        customer_name = dr["customer_name"].ToString(),
                        customer_email = dr["customer_email"].ToString(),
                        customer_phone_number = dr["customer_phone_number"].ToString(),
                        customer_address = dr["customer_address"].ToString()

                    };
                        lista.Add(oCustomers);
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
