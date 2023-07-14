using ProyectoV1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoV1.Interfaces
{
    internal interface IPaymentDAL
    {
        void Create(Payment pPayment);
        void Update(Payment pPayment);
        void Delete(string pID);
        Payment Read(string pID);
        List<Payment> ReadAll();
    }
}
