namespace InheritanceAndEncapsulation.Entities
{
    sealed class OutsourceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourceEmployee()
        {
        }

        public OutsourceEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public sealed override double Payment()
        {
            return base.Payment() + (AdditionalCharge * 1.1);
        }
    }
}
