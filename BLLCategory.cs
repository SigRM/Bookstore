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
    internal class BLLCategory : ICategoryBLL
    {
        DALCategory DAL = new DALCategory();
        
        #region CRUD : CREATE
        public  void Create(Category pCategory)
        {
            if (pCategory.category_id != 0) 
            {
                DAL.Create(pCategory);
            }
        }
        #endregion

        #region CRUD : UPDATE
        public  void Update(Category pCategory)
        {
            if (pCategory.category_id != 0)
            {
                DAL.Update(pCategory);
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
        public List<Category> ReadAlll()
        {
            return DAL.ReadAll();
        }
        #endregion
    }
}
