using ProyectoV1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoV1.Interfaces
{
    internal interface IReviewsBLL
    {
        void Create(Reviews pReviews);
        void Update(Reviews pReviews);
        void Delete(string pID);
        void Read(string pID);
        List<Reviews> ReadAlll();
    }
}
