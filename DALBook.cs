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
    internal class DALBook : IBooksDAL
    {
        #region CRUD : CREATE
        public  void Create(Books pBooks)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_INSERT_Books'"); //Crear SQL Command

                    command.Parameters.AddWithValue("@book_id", int.Parse(pBooks.book_id.ToString()));
                    command.Parameters.AddWithValue("@title", pBooks.title);
                    command.Parameters.AddWithValue("@author", pBooks.author);
                    command.Parameters.AddWithValue("@publisher", pBooks.publisher);
                    command.Parameters.AddWithValue("@genre", pBooks.genre);
                    command.Parameters.AddWithValue("@price", Decimal.Parse(pBooks.price.ToString()));
                    command.Parameters.AddWithValue("@num_copies", int.Parse(pBooks.num_compies.ToString()));

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
        public  void Update(Books pBooks)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_UPDATE_Books'"); //Crear SQL Command

                    command.Parameters.AddWithValue("@book_id", pBooks.book_id);
                    command.Parameters.AddWithValue("@title", pBooks.title);
                    command.Parameters.AddWithValue("@author", pBooks.author);
                    command.Parameters.AddWithValue("@publisher", pBooks.publisher);
                    command.Parameters.AddWithValue("@genre", pBooks.genre);
                    command.Parameters.AddWithValue("@price", pBooks.price);
                    command.Parameters.AddWithValue("@num_copies", pBooks.num_compies);

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
                    var command = new SqlCommand("usp_DELETE_Books_ByID"); //Crear SQL Command

                    //Pasar parametros
                    command.Parameters.AddWithValue("@book_id", pID);

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
        public  Books Read(string pId)
        {
            try
            {
                DataSet ds = null;  //Crear dataset

                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Books_ByID"); //Crear SQL Command

                    //Pasar parametros
                    command.Parameters.AddWithValue("@book_id", pId);
            
                    //Asignar Store Procedures
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
                //Extraer la tabla
                DataTable dr = ds.Tables[0];

                //Crear objeto
                Books oBooks = null;

                if (dr.Rows.Count > 0)
                {
                    oBooks = new Books()
                    {

                    book_id = Convert.ToUInt16(dr.Rows[0]["book_id"].ToString()),
                    title = dr.Rows[0]["title"].ToString(),
                    author = dr.Rows[0]["author"].ToString(),
                    publisher = dr.Rows[0]["publisher"].ToString(),
                    genre = dr.Rows[0]["genre"].ToString(),
                    price = Convert.ToDecimal(dr.Rows[0]["price"].ToString()),
                    num_compies = Convert.ToInt16(dr.Rows[0]["num_copies"].ToString())
                       
                    };
                }
                return oBooks;
            }

            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region CRUD : READALL
        public  List<Books> ReadAll()
        {
            try
            {
                //Crear Dataset
                DataSet ds = null;

                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Books_All"); //Crear SQL Command

                    //Asignar Store Procedures
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
                //Crear lista
                List<Books> lista = new List<Books>();
                //Cargar lista con objetos segun tabla del dataset
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Books oBooks = new Books()
                        {
                            book_id = Convert.ToInt16(dr["book_id"].ToString()),
                            title = dr["title"].ToString(),
                            author = dr["author"].ToString(),
                            publisher = dr["publisher"].ToString(),
                            genre = dr["genre"].ToString(),
                            price = Convert.ToDecimal(dr["price"].ToString()),
                            num_compies = Convert.ToInt16(dr["num_copies"].ToString())

                        };
                        lista.Add(oBooks);
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
