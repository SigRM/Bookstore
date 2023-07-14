using ProyectoV1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoV1.Interfaces
{
    internal interface ICustomersBLL
    {
        void Create(Customers pCustomers);
        void Update(Customers pCustomers);
        void Delete(string pID);
        void Read(string pID);
        List<Customers> ReadAlll();

    }
}
