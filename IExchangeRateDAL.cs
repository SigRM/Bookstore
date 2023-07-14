using ProyectoV1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoV1.Interfaces
{
    internal interface IExchangeRateDAL
    {
        void Create(ExchangeRate pExchangeRate);
        void Update(ExchangeRate pExchangeRate);
        void Delete(string pID);
        ExchangeRate Read(string pID);
        List<ExchangeRate> ReadAll();

    }
}
