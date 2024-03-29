using System;
using System.Globalization;

namespace 10.Exercicio.02.Entities
{
    public class ImportedProducts : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProducts()
        {

        }

        public ImportedProducts(string name, double price, double customFee) : base (name, price)
        {
            CustomsFee = customFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return Name
            + " $ "
            + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
            + " (Custom fee $ )"
            + CustomsFee.ToString("F2", CultureInfo.InvariantCulture)
            + ")";
        }
    
    }
}