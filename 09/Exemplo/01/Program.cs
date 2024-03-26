using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using 09.Exemplo.01.Entities;
using 09.Exemplo.01.Entities.Enuns;

namespace 09.Exemplo.01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                id = 1080;
                Moment = Datetime.Now;
                Status = OrderStatus.PendingPayment;
            };
            
            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

        }
    }
}