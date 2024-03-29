using System;

namespace 10.Exercicio.01.Entities
{
    public class OutSourceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }
    

        public OutSourceEmployee()
        {

        }

        public OutSourceEmployee(string name, int hours, double valuePerHour, additionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    
    }


}