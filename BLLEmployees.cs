using ProyectoV1.DAL;
using ProyectoV1.Entities;
using ProyectoV1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoV1.BLL
{
    internal class BLLEmployees : IEmployeesBLL
    { 
       DALEmployees DAL = new DALEmployees();
    
        #region CRUD : CREATE
        public  void Create(Employees pEmployees)
        {
            if (pEmployees.employee_id != 0) 
            {
                DAL.Create(pEmployees);
            }
        }
        #endregion

        #region CRUD : UPDATE
        public  void Update(Employees pEmployees)
        {
            if (pEmployees.employee_id != 0)
            {
                DAL.Update(pEmployees);
            }

        }
        #endregion

        #region CRUD : DELETE
        public  void Delete(string pID)
        {
            DAL.Delete(pID);
        }
        #endregion

        #region CRUD : READ
        public void Read(string pID)
        {
            DAL.Read(pID);
        }
        #endregion

        #region CRUD : READALL
        public List<Employees> ReadAlll()
        {
            return DAL.ReadAll();
        }
        #endregion
    }
}
