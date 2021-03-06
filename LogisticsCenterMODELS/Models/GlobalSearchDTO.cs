using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsCenterMODELS.Models
{
    public class GlobalSearchDTO
    {
        // General
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string Month { get; set; }
        public int? Year { get; set; }



        public string Supplier { get; set; }
        public DateTime InvoiceSupplierDate { get; set; }
        public string No_Invoice { get; set; }
        public string PaymentDescription { get; set; }
        public string Reference { get; set; }
        public string InvoiceFileRute { get; set; }


        #region
        //// Delay Code Report
        //public string VesselName { get; set; }
        //public string VesselVisit { get; set; }
        //public string Crane { get; set; }
        //public string DelayCode { get; set; }
        //public string Type { get; set; }
        //public string Description { get; set; }
        //public string Account { get; set; }

        //// Graph Report
        //public string Operator { get; set; }
        //// Waiting Time Report
        //public string Service { get; set; }

        //// Transactions
        //public string Status { get; set; }
        //public string FreightKind { get; set; }
        //public string TransactionType { get; set; }
        //public string DriverCardId { get; set; }
        //public string TruckLicenseNumber { get; set; }
        //public int Time { get; set; }

        //// Vessel Performance By Shift
        //public int ShiftNo { get; set; }
        #endregion
        // Paging
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public GlobalSearchDTO()
        {
            this.PageNumber = 1;
            this.PageSize = 50;
        }
        public GlobalSearchDTO(int pageNumber, int pageSize)
        {
            this.PageNumber = pageNumber < 1 ? 1 : pageNumber;
            this.PageSize = pageSize > 50 ? 50 : pageSize;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
