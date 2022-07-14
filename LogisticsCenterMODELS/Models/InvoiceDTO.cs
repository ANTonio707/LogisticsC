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
        public string Supplier { get; set; }
        public DateTime? InvoiceSupplierDate { get; set; }
        public DateTime ReceptionDate { get; set; }
        public string No_Invoice { get; set; }
        public string PaymentDescription { get; set; }
        public string Reference { get; set; }
        public string FileName { get; set; }
        public byte[] FileContent { get; set; }
        //public UploadedFile UploadedFile { get; set; }
        public string InvoiceFileRute { get; set; }
        public bool status { get; set; }
    }
}
