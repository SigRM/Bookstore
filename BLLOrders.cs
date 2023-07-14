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
    internal class BLLOrders : IOrdersBLL
    {
        DALOrders DAL = new DALOrders();
        #region CRUD : CREATE
        public  void Create(Orders pOrders)
        {
            if (pOrders.order_id != 0) //book_id is the variable that supposed to be call in this line
            {
                DAL.Create(pOrders);
            }
        }
        #endregion

        #region CRUD : UPDATE
        public  void Update(Orders pOrders)
        {
            if (pOrders.order_id != 0)
            {
                DAL.Update(pOrders);//book_id is the variable that supposed to be call in this line
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
        public  void Read(string pID)
        {
            DAL.Read(pID);
        }
        #endregion

        #region CRUD : READALL
        public List<Orders> ReadAlll()
        {
            return DAL.ReadAll();
        }
        #endregion
    }
}
