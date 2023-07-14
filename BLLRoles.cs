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
    internal class BLLRoles : IRolesBLL
    {
        DALRoles DAL = new DALRoles();

        #region CRUD : CREATE
        public void Create(Roles pRoles)
        {
            if (pRoles.id !=0) //book_id is the variable that supposed to be call in this line
            {
                DAL.Create(pRoles);
            }
        }
        #endregion

        #region CRUD : UPDATE
        public void Update(Roles pRoles)
        {
            if (pRoles.id !=0)
            {
                DAL.Update(pRoles);//book_id is the variable that supposed to be call in this line
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
        public List<Roles> ReadAlll()
        {
            return DAL.ReadAll();
        }
        #endregion
    }
}
