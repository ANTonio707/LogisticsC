using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsCenterMODELS.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public string Supplier { get; set; }
        public DateTime ReceptionDate { get; set; }
        public DateTime? InvoiceSupplierDate { get; set; }
        public string No_Invoice { get; set; }
        public string PaymentDescription { get; set; }
        public string Reference { get; set; }
        public string InvoiceFileRute { get; set; }
        public string No_FRP { get; set; }
        public string No_Internal_Invoice {get; set;} 
        public int CustomerPayment { get; set; }
        public string CustomerName { get; set;  }
        public int EntranceFee { get; set; }
        public int SupplierPayment { get; set; }
        public int CostRate { get; set;  }

    }
}
