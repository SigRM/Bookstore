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
    internal class BLLPaymentMethod : IPaymentMethodBLL
    {
        DALPaymentMethod DAL = new DALPaymentMethod();
        #region CRUD : CREATE
        public  void Create(PaymentMethod pPaymentMethod)
        {
            if (pPaymentMethod.payment_method_id != 0) //book_id is the variable that supposed to be call in this line
            {
                DAL.Create(pPaymentMethod);
            }
        }
        #endregion

        #region CRUD : UPDATE
        public  void Update(PaymentMethod pPaymentMethod)
        {
            if (pPaymentMethod.payment_method_id != 0)
            {
                DAL.Update(pPaymentMethod);//book_id is the variable that supposed to be call in this line
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
        public List<PaymentMethod> ReadAlll()
        {
            return DAL.ReadAll();
        }
        #endregion
    }
}
