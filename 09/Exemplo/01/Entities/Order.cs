using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using 09.Exemplo.01.Entities.Enuns;

namespace 09.Exemplo.01.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
    }
}