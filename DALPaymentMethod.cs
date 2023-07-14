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
    internal class DALPaymentMethod : IPaymentMethodDAL
    {
        #region CRUD : CREATE
        public  void Create(PaymentMethod pPaymentMethod)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_INSERT_PaymentMethod"); //Crear SQL Command

                    command.Parameters.AddWithValue("@payment_method_id", int.Parse(pPaymentMethod.payment_method_id.ToString()));
                    command.Parameters.AddWithValue("@payment_name", pPaymentMethod.payment_name);
                    command.Parameters.AddWithValue("@description", pPaymentMethod.description);

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
        public  void Update(PaymentMethod pPaymentMethod)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_UPDATE_PaymentMethod"); //Crear SQL Command

                    command.Parameters.AddWithValue("@payment_method_id",pPaymentMethod.payment_method_id);
                    command.Parameters.AddWithValue("@payment_name", pPaymentMethod.payment_name);
                    command.Parameters.AddWithValue("@description", pPaymentMethod.description);

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
                    var command = new SqlCommand(" usp_DELETE_PaymentMethod_ByID"); //Crear SQL Command

                    //Pasar parametros
                    command.Parameters.AddWithValue("@payment_method_id",pID);

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
        public  PaymentMethod Read(string pID)
        {
            try
            {
                DataSet ds = null;  //Crear dataset

                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_PaymentMethod_ByID"); //Crear SQL Command

                    //Pasar parametros
                    command.Parameters.AddWithValue("@payment_method_id", pID); ;

                    //Asignar Store Procedures
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
                //Extraer la tabla
                DataTable dr = ds.Tables[0];

                //Crear objeto
                PaymentMethod oPaymentMethod = null;

                if (dr.Rows.Count > 0)
                {
                    oPaymentMethod = new PaymentMethod()
                    {

                    payment_method_id = Convert.ToInt16(dr.Rows[0]["payment_method_id"].ToString()),
                    payment_name = dr.Rows[0]["payment_name"].ToString(),
                    description = dr.Rows[0]["description"].ToString()
                    };
                }
                return oPaymentMethod;
            }

            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region CRUD : READALL
        public  List<PaymentMethod> ReadAll()
        {
            try
            {
                //Crear Dataset
                DataSet ds = null;

                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_PaymentMethod_All"); //Crear SQL Command

                    //Asignar Store Procedures
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
                //Crear lista
                List<PaymentMethod> lista = new List<PaymentMethod>();
                //Cargar lista con objetos segun tabla del dataset
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        PaymentMethod oPaymentMethod = new PaymentMethod()
                        {

                            payment_method_id = Convert.ToInt16(dr["payment_method_id"].ToString()),
                            payment_name = dr["payment_name"].ToString(),
                            description = dr["description"].ToString()


                        };
                        lista.Add(oPaymentMethod);
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
