using LogisticsCenterMODELS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsCenterMODELS.ViewModels
{
    public class InvoiceViewModel
    {
        public InvoiceDTO Invoice { get; set;  }
        public List<InvoiceDTO> ListInvoices { get; set; }
    }
}
