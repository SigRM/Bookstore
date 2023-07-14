using ProyectoV1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoV1.Interfaces
{
    internal interface IOrdersBLL
    {
        void Create(Orders pOrders);
        void Update(Orders pOrders);
        void Delete(string pID);
        void Read(string pID);
        List<Orders> ReadAlll();


    }
}
