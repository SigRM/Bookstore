using ProyectoV1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoV1.Interfaces
{
    internal interface IAuthorDAL
    {
        void Create(Author pAuthor);
        void Update(Author pAuthor);
        void Delete(string pID);
        Author Read(string pID);
        List<Author> ReadAll();

    }
}
