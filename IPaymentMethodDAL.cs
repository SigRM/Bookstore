using ProyectoV1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoV1.Interfaces
{
    internal interface IPaymentMethodDAL
    {
        void Create(PaymentMethod pPaymentMethod);
        void Update(PaymentMethod pPaymentMethod);
        void Delete(string pID);
        PaymentMethod Read(string pID);
        List<PaymentMethod> ReadAll();

    }
}
