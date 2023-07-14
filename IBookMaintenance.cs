using ProyectoV1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoV1.Interfaces
{
    internal interface IBookMaintenance
    {
        string path { get; }//TODOS los ARCHIVOS van a ocupar una ruta.

        void Add(Books book);

        List<Books> GetTheBook(); //Los metodos no tienen cuerpo, simplemente los cierro con
    }
}
