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
    internal class BLLExchangeRate : IExchangeRateBLL
    {
        DALExchangeRate DAL = new DALExchangeRate();
        #region CRUD : CREATE
        public  void Create(ExchangeRate pExchangeRate)
        {
            if (pExchangeRate.Currency != null)
            {
                DAL.Create(pExchangeRate);
            }
        }
        #endregion

        #region CRUD : UPDATE
        public  void Update(ExchangeRate pExchangeRate)
        {
            if (pExchangeRate.Currency != null)
            {
                DAL.Update(pExchangeRate);
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
        public List<ExchangeRate> ReadAlll()
        {
            return DAL.ReadAll();
        }
        #endregion
    }
}
