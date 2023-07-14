using ProyectoV1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoV1.Interfaces
{
    internal interface IEmployeesBLL
    {
        void Create(Employees pEmployees);
        void Update(Employees pEmployees);
        void Delete(string pID);
        void Read(string pID);
        List<Employees> ReadAlll();
    }
}
