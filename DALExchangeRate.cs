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
    internal class DALExchangeRate : IExchangeRateDAL

    {
        #region CRUD : CREATE
        public  void Create(ExchangeRate pExchangeRate)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_INSERT_ExchangeRate"); //Crear SQL Command

                    command.Parameters.AddWithValue("@Currency", pExchangeRate.Currency);
                    command.Parameters.AddWithValue("@Rate", Decimal.Parse(pExchangeRate.Rate.ToString()));

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
        public  void Update(ExchangeRate pExchangeRate)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_UPDATE_ExchangeRate"); //Crear SQL Command

                    command.Parameters.AddWithValue("@Currency", pExchangeRate.Currency);
                    command.Parameters.AddWithValue("@Rate", pExchangeRate.Rate);

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
                    var command = new SqlCommand("usp_DELETE_ExchangeRate_ByID "); //Crear SQL Command

                    //Pasar parametros
                    command.Parameters.AddWithValue("@Currency", pID);

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
        public  ExchangeRate Read(string pID)
        {
            try
            {
                DataSet ds = null;  //Crear dataset

                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_ExchangeRate_ByID"); //Crear SQL Command

                    //Pasar parametros
                    command.Parameters.AddWithValue("@Currency", pID);

                    //Asignar Store Procedures
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
                //Extraer la tabla
                DataTable dr = ds.Tables[0];

                //Crear objeto
                ExchangeRate oExchangeRate = null;

                if (dr.Rows.Count > 0)
                {
                    oExchangeRate = new ExchangeRate()
                    {

                     Currency = dr.Rows[0]["Currency"].ToString(),
                     Rate = Convert.ToDecimal(dr.Rows[0]["Rate"].ToString())

                    };
                }
                return oExchangeRate;
            }

            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region CRUD : READALL
        public  List<ExchangeRate> ReadAll()
        {
            try
            {
                //Crear Dataset
                DataSet ds = null;

                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_ExchangeRate_All"); //Crear SQL Command

                    //Asignar Store Procedures
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
                //Crear lista
                List<ExchangeRate> lista = new List<ExchangeRate>();
                //Cargar lista con objetos segun tabla del dataset
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        ExchangeRate oExchangeRate = new ExchangeRate()
                        {
                            Currency = dr["Currency"].ToString(),
                            Rate = Convert.ToDecimal(dr["Rate"].ToString())

                        };
                        lista.Add(oExchangeRate);
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
