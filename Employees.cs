using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoV1.Entities
{
    internal class Employees
    {
        public int employee_id { get; set; }
        public string employee_name { get; set; }
        public string employee_email { get; set; }
        public string phone_number { get; set; }
        public DateTime hire_date { get; set; }
        public decimal salary { get; set; }
        public int manager_id { get; set; }
    }
}
