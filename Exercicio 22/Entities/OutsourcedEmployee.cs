namespace Exercicio_22.Entities
{
    internal class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; private set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public sealed override double Payment()
        {
            AdditionalCharge = (AdditionalCharge * 110) / 100;
            return base.Payment() + AdditionalCharge;
        }
    }
}
