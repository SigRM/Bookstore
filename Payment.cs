using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoV1.Entities
{
    internal class Payment
    {
        public int payment_id { get; set; }
        public int order_id { get; set; }
        public int payment_method_id { get; set; }
        public decimal amount { get; set; }
        public decimal exchange_rate { get; set; }
        

        }
    }

