using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace 17.Exemplo02.Entities
{
    public class Product
    {
        public int Id { get; set;}
        public string Name { get; set; }
        public double Price { get; set;}
        public Category category { get; set;}

        public override ToString()
        {
            return Id
            + ", "
            + Name
            + ", "
            + Price.ToString("F2", CultureINfo.InvariantCulture)
            + ", "
            + Category.Tier;
        }
    }
}