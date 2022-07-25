using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LogisticsCenterMODELS.Models
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }

        [Required]
        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }
        [Required]
        public DateTime? InvoiceSupplierDate { get; set; }
        [Required]
        public DateTime? ReceptionDate { get; set; }
        [Required]
        public string No_Invoice { get; set; }
        [Required]
        public bool status { get; set; }
        [Required]
        public string PaymentDescription { get; set; }
        [Required]
        public string Reference { get; set; }
        public string InvoiceFileRute { get; set; }
    }
}
