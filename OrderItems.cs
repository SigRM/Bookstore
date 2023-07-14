using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoV1.Entities
{
    internal class OrderItems
    {
        public int order_item_id { get; set; }
        public int order_id { get; set; }
        public int book_id { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }


    }
}
