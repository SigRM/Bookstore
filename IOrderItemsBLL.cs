using ProyectoV1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoV1.Interfaces
{
    internal interface IOrderItemsBLL
    {
        void Create(OrderItems pOrderItems);
        void Update(OrderItems pOrderItems);
        void Delete(string pID);
        void Read(string pID);
        List<OrderItems> ReadAlll();


    }
}
