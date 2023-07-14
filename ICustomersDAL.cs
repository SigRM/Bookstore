using ProyectoV1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoV1.Interfaces
{
    internal interface ICustomersDAL
    {
        void Create(Customers pCustomers);
        void Update(Customers pCustomers);
        void Delete(string pID);
        Customers Read(string pID);
        List<Customers> ReadAll();

    }
}
