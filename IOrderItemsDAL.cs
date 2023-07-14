using ProyectoV1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoV1.Interfaces
{
    internal interface IOrderItemsDAL
    {
        void Create(OrderItems pOrdenItems);
        void Update(OrderItems pOrdenItems);
        void Delete(string pID);
        OrderItems Read(string pID);
        List<OrderItems> ReadAll();
    }
}
