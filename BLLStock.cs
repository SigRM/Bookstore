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
    internal class BLLStock : IStockBLL
    {
        DALStock DAL = new DALStock();

        #region CRUD : CREATE
        public  void Create(Stock pStock)
        {
            if (pStock.book_location != null) //book_id is the variable that supposed to be call in this line
            {
                DAL.Create(pStock);
            }
        }
        #endregion

        #region CRUD : UPDATE
        public  void Update(Stock pStock)
        {
            if (pStock.book_location != null)
            {
                DAL.Update(pStock);//book_id is the variable that supposed to be call in this line
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
        public List<Stock> ReadAlll()
        {
            return DAL.ReadAll();
        }
        #endregion
    }
}
