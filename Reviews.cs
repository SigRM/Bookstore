using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoV1.Entities
{
    internal class Reviews
    {
        public int review_id { get; set; }
        public Customers customer_id { get; set; }
        public Books book_id { get; set; }
        public int rating { get; set; }
        public string comment { get; set; }
        public DateTime review { get; set; }
    }
}
