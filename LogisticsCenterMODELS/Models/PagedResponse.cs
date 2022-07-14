using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsCenterMODELS.Models
{
    public class PagedResponse<T> : Response<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public Uri FirstPage { get; set; }
        public Uri LastPage { get; set; }
        public int TotalPages { get; set; }
        public int TotalRecords { get; set; }
        public Uri NextPage { get; set; }
        public Uri PreviousPage { get; set; }
        public PagedResponse(T data, int pageNumber, int pageSize, int TotalRecords)
        {
            this.TotalRecords = TotalRecords;
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
            this.Body = data;
            this.Message = null;
            this.IsSuccess = true;
            this.StatusCode = null;
        }
    }
}
