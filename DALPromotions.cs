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
    internal class DALPromotions : IPromotionsDAL
    {
        #region CRUD : CREATE
        public  void Create(Promotions pPromotions)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_INSERT_Promotions"); //Crear SQL Command

                    command.Parameters.AddWithValue("@promotion_id", int.Parse(pPromotions.promotion_id.ToString()));
                    command.Parameters.AddWithValue("@promotion_name", pPromotions.promotion_name);
                    command.Parameters.AddWithValue("@discount",decimal.Parse(pPromotions.discount.ToString()));
                    command.Parameters.AddWithValue("@start_discount_date", DateTime.Parse(pPromotions.start_discount_date.ToString()));
                    command.Parameters.AddWithValue("@end_discount_date", DateTime.Parse(pPromotions.end_discount_date.ToString()));

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
        public  void Update(Promotions pPromotions)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_UPDATE_Promotions"); //Crear SQL Command

                    command.Parameters.AddWithValue("@promotion_id",pPromotions.promotion_id);
                    command.Parameters.AddWithValue("@promotion_name", pPromotions.promotion_name);
                    command.Parameters.AddWithValue("@discount", pPromotions.discount);
                    command.Parameters.AddWithValue("@start_discount_date", pPromotions.start_discount_date);
                    command.Parameters.AddWithValue("@end_discount_date", pPromotions.end_discount_date);

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
                    var command = new SqlCommand("usp_DELETE_Promotions_ByID"); //Crear SQL Command

                    //Pasar parametros
                    command.Parameters.AddWithValue("@promotion_id", pID);

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
        public  Promotions Read(string pID)
        {
            try
            {
                DataSet ds = null;  //Crear dataset

                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Promotions_ByID"); //Crear SQL Command

                    //Pasar parametros
                    command.Parameters.AddWithValue("@promotion_id", pID);
         

                    //Asignar Store Procedures
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
                //Extraer la tabla
                DataTable dr = ds.Tables[0];

                //Crear objeto
                Promotions oPromotions = null;

                if (dr.Rows.Count > 0)
                {
                    oPromotions = new Promotions()
                    {
                    promotion_id = Convert.ToInt16(dr.Rows[0]["promotion_id"].ToString()),
                    promotion_name = dr.Rows[0]["promotion_name"].ToString(),
                    discount = Convert.ToDecimal(dr.Rows[0]["discount"].ToString()),
                    start_discount_date = Convert.ToDateTime(dr.Rows[0]["start_discount_date"].ToString()),
                    end_discount_date = Convert.ToDateTime(dr.Rows[0]["end_discount_date"].ToString())

                    };
                }
                return oPromotions;
            }

            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region CRUD : READALL
        public  List<Promotions> ReadAll()
        {
            try
            {
                //Crear Dataset
                DataSet ds = null;

                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Promotions_All"); //Crear SQL Command

                    //Asignar Store Procedures
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
                //Crear lista
                List<Promotions> lista = new List<Promotions>();
                //Cargar lista con objetos segun tabla del dataset
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Promotions oPromotions = new Promotions()
                        {
                            promotion_id = Convert.ToInt16(dr["promotion_id"].ToString()),
                            promotion_name = dr["promotion_name"].ToString(),
                            discount = Convert.ToDecimal(dr["discount"].ToString()),
                            start_discount_date = Convert.ToDateTime(dr["start_discount_date"].ToString()),
                            end_discount_date = Convert.ToDateTime(dr["end_discount_date"].ToString())


                        };
                        lista.Add(oPromotions);
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
