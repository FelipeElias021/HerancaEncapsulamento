namespace TaxPay.Entities
{
    sealed class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual() { }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public sealed override double Tax()
        {
            double percent;
            if (AnualIncome < 20000)
            {
                percent = 0.15;
            } else
            {

                percent = 0.25;
            }

            return (AnualIncome * percent) - (HealthExpenditures * 0.5);
        }
    }
}
