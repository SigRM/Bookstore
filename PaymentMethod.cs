using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoV1.Entities
{
    internal class PaymentMethod
    {
        public int payment_method_id { get; set; }
        public string payment_name { get; set; }
        public string description { get; set; }

    }
}
