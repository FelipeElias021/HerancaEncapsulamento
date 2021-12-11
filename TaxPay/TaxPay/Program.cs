using System;
using System.Collections.Generic;
using System.Globalization;
using TaxPay.Entities;

namespace TaxPay
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> payers =  new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0;i < n; i++)
            {
                Console.WriteLine($"\nTax payer #{i + 1} data:");
                Console.Write("Individual or company? ");
                string ic = Console.ReadLine().ToLower();

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ic == "individual")
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    payers.Add(new Individual(name, anualIncome, health));
                } 
                else if (ic == "company")
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());

                    payers.Add(new Company(name, anualIncome, employees));
                }
            }

            Console.WriteLine("\nTaxer Paid:");
            double sum = 0;
            foreach (TaxPayer payer in payers)
            {
                Console.WriteLine(payer);
                sum += payer.Tax();
            }

            Console.WriteLine($"\nTotal Taxes: {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}