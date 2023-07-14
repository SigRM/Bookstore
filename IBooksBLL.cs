using ProyectoV1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoV1.Interfaces
{
    internal interface IBooksBLL
    {
        void Create(Books pBooks);
        void Update(Books pBooks);
        void Delete(string pID);
        void Read(string pID);
        List<Books> ReadAlll();

    }
}
