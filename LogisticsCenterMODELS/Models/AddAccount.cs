using System;
using LogisticsCenterMODELS.Models;
using Microsoft.AspNetCore.Http;

namespace LogisticsCenterMODELS.Models
{
    public class AddAccount
    {
        public string Supplier { get; set; }
        public DateTime? ReceptionDate { get; set; }
        public DateTime? InvoiceSupplierDate { get; set; }
        public string No_Invoice { get; set; }
        public string PaymentDescription { get; set; }
        public string Reference { get; set; }
        public string FileName { get; set; }
        public byte[] FileContent { get; set; }

        //public IFormFile InvoiceFileRute { get; set; }
    }
}
