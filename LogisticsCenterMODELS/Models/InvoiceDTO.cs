using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsCenterMODELS.Models
{
    public class InvoiceDTO
    {
        public int InvoiceId { get; set; }
        public int SupplierId { get; set; }
        [Required]
        public DateTime? InvoiceSupplierDate { get; set; }
        [Required]
        public DateTime ReceptionDate { get; set; }
        [Required]
        public string No_Invoice { get; set; }
        [Required]
        public string PaymentDescription { get; set; }
        [Required]
        public string Reference { get; set; }
        public string FileName { get; set; }
        public byte[] FileContent { get; set; }
        //public UploadedFile UploadedFile { get; set; }
        public string InvoiceFileRute { get; set; }
        public bool status { get; set; }

        public virtual Supplier Supplier { get; set; }
    }

    public class InvoiceValidDTO
    {
        public int SupplierId { get; set; }
        public string No_Invoice { get; set; }
    }
}
