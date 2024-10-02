using Data1;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Binvoice
    {
        
        
        public List<invoices> Get()
        {
            Dinvoices Dinvoices = new Dinvoices();

            return Dinvoices.Get();
        }
    }
}
