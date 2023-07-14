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
    internal class DALOrders : IOrdersDAL
    {
        #region CRUD : CREATE
        public  void Create(Orders pOrders)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_INSERT_Orders"); //Crear SQL Command

                    command.Parameters.AddWithValue("@order_id", int.Parse(pOrders.order_id.ToString()));
                    command.Parameters.AddWithValue("@customer_id", int.Parse(pOrders.customer_id.ToString()));
                    command.Parameters.AddWithValue("@order_date", DateTime.Parse(pOrders.order_date.ToString()));
                    command.Parameters.AddWithValue("@total_price", decimal.Parse(pOrders.total_price.ToString()));
                    command.Parameters.AddWithValue("@statusO", pOrders.status);
                    command.Parameters.AddWithValue("@shipping_address", pOrders.shipping_address);
                    command.Parameters.AddWithValue("@shipping_city", pOrders.shipping_city);
                    command.Parameters.AddWithValue("@shipping_zipcode", pOrders.billing_zipcode);
                    command.Parameters.AddWithValue("@billing_address", pOrders.billing_address);
                    command.Parameters.AddWithValue("@billing_city", pOrders.billing_city);
                    command.Parameters.AddWithValue("@billing_zipcode", pOrders.billing_zipcode);


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
        public void Update(Orders pOrders)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_UPDATE_Orders"); //Crear SQL Command

                    command.Parameters.AddWithValue("@order_id",pOrders.order_id);
                    command.Parameters.AddWithValue("@customer_id",pOrders.customer_id);
                    command.Parameters.AddWithValue("@order_date", pOrders.order_date);
                    command.Parameters.AddWithValue("@total_price", pOrders.total_price);
                    command.Parameters.AddWithValue("@statusO", pOrders.status);
                    command.Parameters.AddWithValue("@shipping_address", pOrders.shipping_address);
                    command.Parameters.AddWithValue("@shipping_city", pOrders.shipping_city);
                    command.Parameters.AddWithValue("@shipping_zipcode", pOrders.billing_zipcode);
                    command.Parameters.AddWithValue("@billing_address", pOrders.billing_address);
                    command.Parameters.AddWithValue("@billing_city", pOrders.billing_city);
                    command.Parameters.AddWithValue("@billing_zipcode", pOrders.billing_zipcode);

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
                    var command = new SqlCommand("usp_DELETE_Orders_ByID "); //Crear SQL Command

                    //Pasar parametros
                    command.Parameters.AddWithValue("@order_id", pID);

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
        public  Orders Read(string pID)
        {
            try
            {
                DataSet ds = null;  //Crear dataset

                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Orders_ByID"); //Crear SQL Command

                    //Pasar parametros
                    command.Parameters.AddWithValue("@order_id", pID);

                    //Asignar Store Procedures
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
                //Extraer la tabla
                DataTable dr = ds.Tables[0];

                //Crear objeto
                Orders oOrders = null;

                if (dr.Rows.Count > 0)
                {
                    oOrders = new Orders()
                    {
                    order_id = Convert.ToInt16(dr.Rows[0]["order_id"].ToString()),
                    customer_id = Convert.ToInt16(dr.Rows[0]["customer_id"].ToString()),
                    order_date = Convert.ToDateTime(dr.Rows[0]["order_date"].ToString()),
                    total_price = Convert.ToDecimal(dr.Rows[0]["total_price"].ToString()),
                    status = dr.Rows[0]["statusO"].ToString(),
                    shipping_address = dr.Rows[0]["shipping_address"].ToString(),
                    shipping_city = dr.Rows[0]["shipping_city"].ToString(),
                    shipping_zipcode = dr.Rows[0]["shipping_zipcode"].ToString(),
                    billing_address = dr.Rows[0]["billing_address"].ToString(),
                    billing_city = dr.Rows[0]["billing_city"].ToString(),
                    billing_zipcode = dr.Rows[0]["billing_zipcode"].ToString()

                    };
                }
                return oOrders;
            }

            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region CRUD : READALL
        public  List<Orders> ReadAll()
        {
            try
            {
                //Crear Dataset
                DataSet ds = null;

                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Orders_All"); //Crear SQL Command

                    //Asignar Store Procedures
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
                //Crear lista
                List<Orders> lista = new List<Orders>();
                //Cargar lista con objetos segun tabla del dataset
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Orders oOrders = new Orders()
                        {

                            order_id = Convert.ToInt16(dr["order_id"].ToString()),
                            customer_id = Convert.ToInt16(dr["customer_id"].ToString()),
                            order_date = Convert.ToDateTime(dr["order_date"].ToString()),
                            total_price = Convert.ToDecimal(dr["total_price"].ToString()),
                            status = dr["statusO"].ToString(),
                            shipping_address = dr["shipping_address"].ToString(),
                            shipping_city = dr["shipping_city"].ToString(),
                            shipping_zipcode = dr["shipping_zipcode"].ToString(),
                            billing_address = dr["billing_address"].ToString(),
                            billing_city = dr["billing_city"].ToString(),
                            billing_zipcode = dr["billing_zipcode"].ToString()
                        };
                        lista.Add(oOrders);
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
