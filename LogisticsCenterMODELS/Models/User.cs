using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LogisticsCenterMODELS.Models
{
    public class User
    {
        public string Status { get; set; }

        public string Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string FullName { get; set; }
        public string JobFunction { get; set; }
        public string Token { get; set; }
        public string GroupAccess { get; set; }
   
    }
}
