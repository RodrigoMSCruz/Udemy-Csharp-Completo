using System;
using System.Globalization;

namespace 10.Exercicio.02.Entities
{
    public class UsedProduct
    {
        public DateTime ManufacturedDate { get; set;}

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufacturedDate) : base(name, price)
        {
            ManufacturedDate = manufacturedDate;
        }

        public override string PriceTag()
        {
            return Name
            + " (used) $ "
            + Price.ToString("F2", CultureInfo.InvariantCulture)
            + " (Manufactured date: )"
            + ManufacturedDate.ToString("dd/MM/yyyy")
            + ")";
        }
    }
}