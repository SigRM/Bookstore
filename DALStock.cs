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
    internal class DALStock : IStockDAL
    {
        #region CRUD : CREATE
        public  void Create(Stock pStock)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_INSERT_Stock"); //Crear SQL Command

                   // command.Parameters.AddWithValue("@book_id", Books.parse(pStock.book_id.ToString()));
                    command.Parameters.AddWithValue("@book_location", pStock.book_location);
                    command.Parameters.AddWithValue("@quantity", int.Parse(pStock.quantity.ToString()));

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
        public  void Update(Stock pStock)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_UPDATE_Stock"); //Crear SQL Command

                    command.Parameters.AddWithValue("@book_id", pStock.book_id);
                    command.Parameters.AddWithValue("@book_location", pStock.book_location);
                    command.Parameters.AddWithValue("@quantity", pStock.quantity);

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
                    var command = new SqlCommand("usp_DELETE_Stock_ByID"); //Crear SQL Command

                    //Pasar parametros
                    command.Parameters.AddWithValue("@book_id", pID);
                    command.Parameters.AddWithValue("@book_location", pID);

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
        public  Stock Read(string pID)
        {
            try
            {
                DataSet ds = null;  //Crear dataset

                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Stock_ByID"); //Crear SQL Command

                    //Pasar parametros
                    command.Parameters.AddWithValue("@book_id", pID);
                    command.Parameters.AddWithValue("@book_location", pID);

                    //Asignar Store Procedures
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
                //Extraer la tabla
                DataTable dr = ds.Tables[0];

                //Crear objeto
                Stock oStock = null;

                if (dr.Rows.Count > 0)
                {
                    oStock = new Stock()
                    {
                    // book_id = Convert.ToInt16(dr.Rows[0]["book_id"].ToString()),
                     book_location = dr.Rows[0]["book_location"].ToString(),
                     quantity = Convert.ToInt16(dr.Rows[0]["quantity"].ToString())

                    };
                }
                return oStock;
            }

            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region CRUD : READALL
        public List<Stock> ReadAll()
        {
            try
            {
                //Crear Dataset
                DataSet ds = null;

                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Stock_All"); //Crear SQL Command

                    //Asignar Store Procedures
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
                //Crear lista
                List<Stock> lista = new List<Stock>();
                //Cargar lista con objetos segun tabla del dataset
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Stock oStock = new Stock()
                        {

                            // book_id = Convert.ToInt16(dr["book_id"].ToString()),
                            book_location = dr["book_location"].ToString(),
                            quantity = Convert.ToInt16(dr["quantity"].ToString())
                           

                        };
                        lista.Add(oStock);
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
