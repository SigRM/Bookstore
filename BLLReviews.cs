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
    internal class BLLReviews : IReviewsBLL
    {
        DALReviews DAL = new DALReviews();

        #region CRUD : CREATE
        public  void Create(Reviews pReviews)
        {
            if (pReviews.review_id != 0) //book_id is the variable that supposed to be call in this line
            {
                DAL.Create(pReviews);
            }
        }
        #endregion

        #region CRUD : UPDATE
        public  void Update(Reviews pReviews)
        {
            if (pReviews.review_id != 0)
            {
                DAL.Update(pReviews);//book_id is the variable that supposed to be call in this line
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
        public List<Reviews> ReadAlll()
        {
            return DAL.ReadAll();
        }
        #endregion
    }
}
