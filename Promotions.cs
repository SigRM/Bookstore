using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoV1.Entities
{
    internal class Promotions
    {
        public int promotion_id { get; set; }
        public string promotion_name { get; set; }
        public decimal discount { get; set; }
        public DateTime start_discount_date { get; set; }
        public DateTime end_discount_date { get; set; }
    }
}
