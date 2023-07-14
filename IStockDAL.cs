using ProyectoV1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoV1.Interfaces
{
    internal interface IStockDAL
    {
        void Create(Stock pStock);
        void Update(Stock pStock);
        void Delete(string pID);
        Stock Read(string pID);
        List<Stock> ReadAll();
    }
}
