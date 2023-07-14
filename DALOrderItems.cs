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
    internal class DALOrderItems : IOrderItemsDAL
    {
        #region CRUD : CREATE
        public void Create(OrderItems pOrdenItems)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_INSERT_Order_Items'"); //Crear SQL Command

                    command.Parameters.AddWithValue("@order_item_id", int.Parse(pOrdenItems.order_item_id.ToString()));
                    command.Parameters.AddWithValue("@order_id", int.Parse(pOrdenItems.order_id.ToString()));
                    command.Parameters.AddWithValue("@book_id", int.Parse(pOrdenItems.book_id.ToString()));
                    command.Parameters.AddWithValue("@quantity", int.Parse(pOrdenItems.quantity.ToString()));
                    command.Parameters.AddWithValue("@price", decimal.Parse(pOrdenItems.price.ToString()));

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
        public  void Update(OrderItems pOrdenItems)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_UPDATE_Order_Items"); //Crear SQL Command

                    command.Parameters.AddWithValue("@order_item_id", pOrdenItems.order_item_id);
                    command.Parameters.AddWithValue("@order_id", pOrdenItems.order_id);
                    command.Parameters.AddWithValue("@book_id", pOrdenItems.book_id);
                    command.Parameters.AddWithValue("@quantity", pOrdenItems.quantity);
                    command.Parameters.AddWithValue("@price", pOrdenItems.price);

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
                    var command = new SqlCommand("usp_DELETE_Order_Items_ByID "); //Crear SQL Command

                    //Pasar parametros
                    command.Parameters.AddWithValue("@order_item_id", pID);

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
        public  OrderItems Read(string pID)
        {
            try
            {
                DataSet ds = null;  //Crear dataset

                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Order_Items_ByID "); //Crear SQL Command

                    //Pasar parametros
                    command.Parameters.AddWithValue("@order_item_id", pID);


                    //Asignar Store Procedures
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
                //Extraer la tabla
                DataTable dr = ds.Tables[0];

                //Crear objeto
                OrderItems oOrderItems = null;

                if (dr.Rows.Count > 0)
                {
                    oOrderItems = new OrderItems()
                    {

                    order_item_id = Convert.ToUInt16(dr.Rows[0]["order_item_id"].ToString()),
                    order_id = Convert.ToUInt16(dr.Rows[0]["order_id"].ToString()),
                    book_id = Convert.ToUInt16(dr.Rows[0]["book_id"].ToString()),
                    quantity = Convert.ToUInt16(dr.Rows[0]["quantity"].ToString()),
                    price = Convert.ToDecimal(dr.Rows[0]["price"].ToString())
                    };
                }
                return oOrderItems;
            }

            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region CRUD : READALL
        public  List<OrderItems> ReadAll()
        {
            try
            {
                //Crear Dataset
                DataSet ds = null;

                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Order_Items_All"); //Crear SQL Command

                    //Asignar Store Procedures
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
                //Crear lista
                List<OrderItems> lista = new List<OrderItems>();
                //Cargar lista con objetos segun tabla del dataset
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        OrderItems oOrderItems = new OrderItems()
                        {

                            order_item_id = Convert.ToUInt16(dr["order_item_id"].ToString()),
                            order_id = Convert.ToUInt16(dr["order_id"].ToString()),
                            book_id = Convert.ToUInt16(dr["book_id"].ToString()),
                            quantity = Convert.ToUInt16(dr["quantity"].ToString()),
                            price = Convert.ToDecimal(dr["price"].ToString())

                        };
                        lista.Add(oOrderItems);
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
