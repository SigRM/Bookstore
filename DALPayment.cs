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
    internal class DALPayment : IPaymentDAL
    {
        #region CRUD : CREATE
        public void Create(Payment pPayment)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_INSERT_Payment"); //Crear SQL Command

                    command.Parameters.AddWithValue("@payment_id", int.Parse(pPayment.payment_id.ToString()));
                  //  command.Parameters.AddWithValue("@order_id", Orders.parse(pPayment.order_id.ToString));
                 //   command.Parameters.AddWithValue("@payment_method_id", PaymentMethod.Parse(pPayment.payment_method_id.ToString()));
                    command.Parameters.AddWithValue("@amount", decimal.Parse(pPayment.amount.ToString()));
                    command.Parameters.AddWithValue("@exchange_rate", decimal.Parse(pPayment.exchange_rate.ToString()));

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
        public  void Update(Payment pPayment)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_UPDATE_Payment"); //Crear SQL Command

                    command.Parameters.AddWithValue("@payment_id", pPayment.payment_id);
                    command.Parameters.AddWithValue("@order_id",pPayment.order_id);
                    command.Parameters.AddWithValue("@payment_method_id", pPayment.payment_method_id);
                    command.Parameters.AddWithValue("@amount", pPayment.amount);
                    command.Parameters.AddWithValue("@exchange_rate", pPayment.exchange_rate);

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
                    var command = new SqlCommand("usp_DELETE_Payment_ByID"); //Crear SQL Command

                    //Pasar parametros
                    command.Parameters.AddWithValue("@payment_id",pID);

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
        public  Payment Read(string pID)
        {
            try
            {
                DataSet ds = null;  //Crear dataset

                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Payment_ByID"); //Crear SQL Command

                    //Pasar parametros
                    command.Parameters.AddWithValue("@payment_id", pID);


                    //Asignar Store Procedures
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
                //Extraer la tabla
                DataTable dr = ds.Tables[0];

                //Crear objeto
                Payment oPayment = null;

                if (dr.Rows.Count > 0)
                {
                    oPayment = new Payment()
                    {

                    payment_id = Convert.ToInt16(dr.Rows[0]["payment_id"].ToString()),
                  //  order_id = Convert(dr.Rows[0]["order_id"].ToString()),
                  //  payment_method_id = Convert.(dr.Rows[0]["payment_method_id"].ToString()),
                    amount = Convert.ToDecimal(dr.Rows[0]["amount"].ToString()),
                    exchange_rate = Convert.ToDecimal(dr.Rows[0]["exchange_rate"].ToString())



                };
                }
                return oPayment;
            }

            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region CRUD : READALL
        public  List<Payment> ReadAll()
        {
            try
            {
                //Crear Dataset
                DataSet ds = null;

                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Payment_All"); //Crear SQL Command

                    //Asignar Store Procedures
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
                //Crear lista
                List<Payment> lista = new List<Payment>();
                //Cargar lista con objetos segun tabla del dataset
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Payment oPayment = new Payment()
                        {

                            payment_id = Convert.ToInt16(dr["payment_id"].ToString()),
                            //  order_id = Convert(dr["order_id"].ToString()),
                            //  payment_method_id = Convert.(dr["payment_method_id"].ToString()),
                            amount = Convert.ToDecimal(dr["amount"].ToString()),
                            exchange_rate = Convert.ToDecimal(dr["exchange_rate"].ToString())

     

                        };
                        lista.Add(oPayment);
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
