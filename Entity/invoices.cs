using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class invoices
    {
        public int invoiceID { get; set; }
        public int facturaID { get; set; }
        public int customerID { get; set; }
        public DateTime date { get; set; }
        public decimal total { get; set; }
        
    }
}
