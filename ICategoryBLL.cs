using ProyectoV1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoV1.Interfaces
{
    internal interface ICategoryBLL
    {
        void Create(Category pCategory);
        void Update(Category pCategory);
        void Delete(string pID);
        void Read(string pID);
        List<Category> ReadAlll();
    }
}
