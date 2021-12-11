namespace TaxPay.Entities
{
    sealed class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company() { }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public sealed override double Tax()
        {
            double percent;
            if (AnualIncome > 10)
            {
                percent = 0.14;
            }
            else
            {

                percent = 0.16;
            }

            return AnualIncome * percent;
        }
    }
}
