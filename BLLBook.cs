
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
    internal class BLLBook : IBooksBLL
    {
        DALBook DAL = new DALBook();

        #region CRUD : CREATE
        public  void Create(Books pBooks)
        {
            if(pBooks.book_id != 0)
            {
                DAL.Create(pBooks);
            }
        }
        #endregion

        #region CRUD : UPDATE
        public  void Update(Books pBooks)
        {
            if (pBooks.book_id != 0)
            {
                DAL.Update(pBooks);
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
        public List<Books> ReadAlll()
        {
            return DAL.ReadAll();
        }
        #endregion


    }
}
