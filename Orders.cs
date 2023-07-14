using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoV1.Entities
{
    internal class Orders
    {
        public int order_id { get; set; }
        public int customer_id { get; set; }
        public DateTime order_date { get; set; }
        public decimal total_price { get; set; }
        public string status { get; set; }
        public string shipping_address { get; set; }
        public string shipping_city { get; set; }
        public string shipping_zipcode { get; set; }
        public string billing_address { get; set; }
        public string billing_city{ get; set; }
        public string billing_zipcode { get; set; }
    }
}
