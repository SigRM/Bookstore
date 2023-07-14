using ProyectoV1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoV1.Interfaces
{
    internal interface ICategoryDAL
    {
        void Create(Category pCategory);
        void Update(Category pCategory);
        void Delete(string pID);
        Category Read(string pID);
        List<Category> ReadAll();

    }
}
