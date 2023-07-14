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
    internal class BLLPromotions : IPromotionsBLL
    {
        DALPromotions DAL = new DALPromotions();

        #region CRUD : CREATE
        public void Create(Promotions pPromotions)
        {
            if (pPromotions.promotion_id!= 0) //book_id is the variable that supposed to be call in this line
            {
                DAL.Create(pPromotions);
            }
        }
        #endregion

        #region CRUD : UPDATE
        public  void Update(Promotions pPromotions)
        {
            if (pPromotions.promotion_id != 0)
            {
                DAL.Update(pPromotions);//book_id is the variable that supposed to be call in this line
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
        public List<Promotions> ReadAlll()
        {
            return DAL.ReadAll();
        }
        #endregion
    }
}
