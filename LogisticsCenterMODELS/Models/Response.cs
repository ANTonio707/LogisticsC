using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsCenterMODELS.Models
{
    public class Response<T> : IResponse<T>
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public T Body { get; set; }
        public string StatusCode { get; set; }
        public MetaData MetaData { get; set; }
    }
}
