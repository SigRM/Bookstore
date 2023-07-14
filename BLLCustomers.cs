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
    internal class BLLCustomers : ICustomersBLL
    {
        DALCustomers DAL = new DALCustomers();
        #region CRUD : CREATE
        public  void Create(Customers pCustomers)
        {
            if (pCustomers.customer_id != 0) //book_id is the variable that supposed to be call in this line
            {
                DAL.Create(pCustomers);
            }
        }
        #endregion

        #region CRUD : UPDATE
        public  void Update(Customers pCustomers)
        {
            if (pCustomers.customer_id != 0)
            {
                DAL.Update(pCustomers);//book_id is the variable that supposed to be call in this line
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
        public List<Customers> ReadAlll()
        {
            return DAL.ReadAll();
        }
        #endregion
    }
}
