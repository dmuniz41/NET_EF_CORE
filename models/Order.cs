using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NET_EF_CORE.models
{
    public class Order
    {
        public int Id {get; set;}
        public DateTime OrderPlaced {get; set;}
        public DateTime? OrderFullFilled {get; set;}
        public int CustomerId {get; set;}
        public Customer Customer {get; set;} = null!;
        public ICollection<OrderDetail> OrderDetails {get; set;} = null!;
    }
}