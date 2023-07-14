using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoV1.Entities
{
    internal class Books
    {
        public int book_id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public string genre { get; set; }
        public decimal price { get; set; }
        public int num_compies { get; set; }


    }
}
