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
    internal class DALEmployees : IEmployeesDAL
    {
        #region CRUD : CREATE
        public  void Create(Employees pEmployees)           
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_INSERT_Employees"); //Crear SQL Command

                    command.Parameters.AddWithValue("@employee_id", int.Parse(pEmployees.employee_id.ToString()));
                    command.Parameters.AddWithValue("@employee_name", pEmployees.employee_name);
                    command.Parameters.AddWithValue("@employee_email", pEmployees.employee_email);
                    command.Parameters.AddWithValue("@phone_number", pEmployees.phone_number);
                    command.Parameters.AddWithValue("@hire_date", DateTime.Parse(pEmployees.hire_date.ToString()));
                    command.Parameters.AddWithValue("@salary",Decimal.Parse(pEmployees.salary.ToString()));
                    command.Parameters.AddWithValue("@manager_id", int.Parse(pEmployees.manager_id.ToString()));

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
        public  void Update(Employees pEmployees)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_UPDATE_Employees"); //Crear SQL Command

                    command.Parameters.AddWithValue("@employee_id", pEmployees.employee_id);
                    command.Parameters.AddWithValue("@employee_name", pEmployees.employee_name);
                    command.Parameters.AddWithValue("@employee_email", pEmployees.employee_email);
                    command.Parameters.AddWithValue("@phone_number", pEmployees.phone_number);
                    command.Parameters.AddWithValue("@hire_date",pEmployees.hire_date);
                    command.Parameters.AddWithValue("@salary",pEmployees.salary);
                    command.Parameters.AddWithValue("@manager_id",pEmployees.manager_id);

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
                    var command = new SqlCommand("usp_DELETE_Employees_ByID "); //Crear SQL Command

                    //Pasar parametros
                    command.Parameters.AddWithValue("@employee_id", pID);
    
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
        public  Employees Read(string pId)
        {
            try
            {
                DataSet ds = null;  //Crear dataset

                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Employees_ByID "); //Crear SQL Command

                    //Pasar parametros
                    command.Parameters.AddWithValue("@employee_id", pId);

                    //Asignar Store Procedures
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
                //Extraer la tabla
                DataTable dr = ds.Tables[0];

                //Crear objeto
                Employees oEmployees = null;

                if (dr.Rows.Count > 0)
                {
                    oEmployees = new Employees()
                    {

                    employee_id = Convert.ToInt16(dr.Rows[0]["employee_id"].ToString()),
                    employee_name = dr.Rows[0]["employee_name"].ToString(),
                    employee_email = dr.Rows[0]["employee_email"].ToString(),
                    phone_number = dr.Rows[0]["phone_number"].ToString(),
                    hire_date = Convert.ToDateTime(dr.Rows[0]["hire_date"].ToString()),
                    salary = Convert.ToDecimal(dr.Rows[0]["salary"].ToString()),
                    manager_id = Convert.ToInt16(dr.Rows[0]["manager_id"].ToString())

                };
                }
                return oEmployees;
            }

            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region CRUD : READALL
        public  List<Employees> ReadAll()
        {
            try
            {
                //Crear Dataset
                DataSet ds = null;

                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_Employees_All"); //Crear SQL Command

                    //Asignar Store Procedures
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
                //Crear lista
                List<Employees> lista = new List<Employees>();
                //Cargar lista con objetos segun tabla del dataset
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Employees oEmployees = new Employees()
                        {
                            employee_id = Convert.ToInt16(dr["employee_id"].ToString()),
                            employee_name = dr["employee_name"].ToString(),
                            employee_email = dr["employee_email"].ToString(),
                            phone_number = dr["phone_number"].ToString(),
                            hire_date = Convert.ToDateTime(dr["hire_date"].ToString()),
                            salary = Convert.ToDecimal(dr["salary"].ToString()),
                            manager_id = Convert.ToInt16(dr["manager_id"].ToString())

                        };
                        lista.Add(oEmployees);
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
