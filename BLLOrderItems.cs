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
    internal class BLLOrderItems : IOrderItemsBLL
    {
        DALOrderItems DAL = new DALOrderItems();
        #region CRUD : CREATE
        public  void Create(OrderItems pOrderItems)
        {
            if (pOrderItems.order_id != 0)
            {
                DAL.Create(pOrderItems);
            }
        }
        #endregion

        #region CRUD : UPDATE
        public void Update(OrderItems pOrderItems)
        {
            if (pOrderItems.order_id != 0)
            {
                DAL.Update(pOrderItems);
            }

        }
        #endregion

        #region CRUD : DELETE
        public void Delete(string pID)
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
        public List<OrderItems> ReadAlll()
        {
            return DAL.ReadAll();
        }
        #endregion
    }
}
