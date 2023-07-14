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
    internal class BLLPayment : IPaymentBLL
    {
        DALPayment DAL = new DALPayment();
        #region CRUD : CREATE
        public  void Create(Payment pPayment)
        {
            if (pPayment.payment_id != 0) //book_id is the variable that supposed to be call in this line
            {
                DAL.Create(pPayment);
            }
        }
        #endregion

        #region CRUD : UPDATE
        public  void Update(Payment pPayment)
        {
            if (pPayment.payment_id != 0)
            {
                DAL.Update(pPayment);//book_id is the variable that supposed to be call in this line
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
        public List<Payment> ReadAlll()
        {
            return DAL.ReadAll();
        }
        #endregion
    }
}
