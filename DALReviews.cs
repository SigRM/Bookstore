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
    internal class DALReviews : IReviewsDAL
    {
        #region CRUD : CREATE
        public  void Create(Reviews pReviews)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_INSERT_Reviews"); //Crear SQL Command

                    command.Parameters.AddWithValue("@review_id", int.Parse(pReviews.review_id.ToString()));
                  //  command.Parameters.AddWithValue("@customer_id", Customers.parse(pReviews.customer_id.ToString()));
                 //   command.Parameters.AddWithValue("@book_id", Books.parse(pReviews.book_id.ToString()));
                    command.Parameters.AddWithValue("@rating", int.Parse(pReviews.rating.ToString()));
                    command.Parameters.AddWithValue("@comment", pReviews.comment);
                    command.Parameters.AddWithValue("@review", DateTime.Parse(pReviews.review.ToString()));

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
        public void Update(Reviews pReviews)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_UPDATE_Reviews"); //Crear SQL Command

                    command.Parameters.AddWithValue("@review_id", pReviews.review_id);
                    command.Parameters.AddWithValue("@customer_id",pReviews.customer_id);
                    command.Parameters.AddWithValue("@book_id", pReviews.book_id);
                    command.Parameters.AddWithValue("@rating", pReviews.rating);
                    command.Parameters.AddWithValue("@comment", pReviews.comment);
                    command.Parameters.AddWithValue("@review", pReviews.review);

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
                    var command = new SqlCommand("usp_DELETE_Reviews_ByID"); //Crear SQL Command

                    //Pasar parametros
                    command.Parameters.AddWithValue("@review_id", pID);

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
        public  Reviews Read(string pId)
        {
            try
            {
                DataSet ds = null;  //Crear dataset

                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Reviews_ByID"); //Crear SQL Command

                    //Pasar parametros
                    command.Parameters.AddWithValue("@review_id", pId);

                    //Asignar Store Procedures
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
                //Extraer la tabla
                DataTable dr = ds.Tables[0];

                //Crear objeto
                Reviews oReviews = null;

                if (dr.Rows.Count > 0)
                {
                    oReviews = new Reviews()
                    {
                    review_id = int.Parse(dr.Rows[0]["review_id"].ToString()),
                  //  customer_id = Customers.parse(dr.Rows[0]["customer_id"].ToString()),
                  //  book_id = Books(dr.Rows[0]["book_id"].ToString()),
                    rating = int.Parse(dr.Rows[0]["rating"].ToString()),
                    comment = dr.Rows[0]["comment"].ToString(),
                    review = DateTime.Parse(dr.Rows[0]["review"].ToString())

                    };
                }
                return oReviews;
            }

            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region CRUD : READALL
        public  List<Reviews> ReadAll()
        {
            try
            {
                //Crear Dataset
                DataSet ds = null;

                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Reviews_All"); //Crear SQL Command

                    //Asignar Store Procedures
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
                //Crear lista
                List<Reviews> lista = new List<Reviews>();
                //Cargar lista con objetos segun tabla del dataset
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Reviews oReviews = new Reviews()
                        {

                            review_id = int.Parse(dr["review_id"].ToString()),
                            //  customer_id = Customers.parse(dr["customer_id"].ToString()),
                            //  book_id = Books(dr["book_id"].ToString()),
                            rating = int.Parse(dr["rating"].ToString()),
                            comment = dr["comment"].ToString(),
                            review = DateTime.Parse(dr["review"].ToString())


                        };
                        lista.Add(oReviews);
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
