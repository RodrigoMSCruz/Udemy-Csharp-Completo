using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 09.Exemplo.01
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
    }
}