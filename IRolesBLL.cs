using ProyectoV1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoV1.Interfaces
{
    internal interface IRolesBLL
    {
        void Create(Roles pRoles);
        void Update(Roles pRoles);
        void Delete(string pID);
        void Read(string pID);
        List<Roles> ReadAlll();
    }
}
