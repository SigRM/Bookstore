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
    internal class BLLAuthor : IAuthorBLL
    {
        DALAuthor DAL = new DALAuthor();

        #region CRUD : CREATE
        public  void Create(Author pAuthor)
        {
            if (pAuthor.author_id != 0) 
            {
                DAL.Create(pAuthor);
            }
        }
        #endregion

        #region CRUD : UPDATE
        public  void Update(Author pAuthor)
        {
            if (pAuthor.author_id!= 0)
            {
                DAL.Update(pAuthor);
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
        public List<Author> ReadAlll()
        {
            return DAL.ReadAll();
        }
        #endregion
    }
}
