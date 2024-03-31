using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NET_EF_CORE.models
{
    public class Customer
    {
        public int Id {get; set;}
        public string FirstName {get; set;} = null!;
        public string LastName {get; set;} = null!;
        public string? Address {get; set;}
        public string? Phone {get; set;}
        public string? Email {get; set;}
        public ICollection<Order> Orders {get; set;} = null!;
    }
}