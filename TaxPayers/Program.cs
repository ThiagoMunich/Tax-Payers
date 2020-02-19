using System;
using System.Globalization;
using System.Collections.Generic;
using TaxPayers.Entities;

namespace TaxPayers {
    class Program {
        static void Main(string[] args) {

            List<TaxPayer> list = new List<TaxPayer>(); // creating a superclass list

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            // Loop to fill the list
            for (int i = 1; i <= n; i++) {

                Console.WriteLine($"\nTax payer #{i} data:");

                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i') {
                    Console.Write("Health expenditures: ");
                    double healthExpenditure = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, healthExpenditure));
                }
                else if (ch == 'c') {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberOfEmployees));
                }
                else {
                    Console.WriteLine("Invalid option. ");
                    return;
                }
            }// end for

            double sum = 0.0; // variable to sum the taxes paid by all tax payers

            Console.WriteLine("\nTAXES PAID: ");
            foreach (TaxPayer payer in list) {
                Console.Write(payer.Name + ": $ " + payer.Tax().ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine();
                sum += payer.Tax();
            }

            Console.Write($"\nTOTAL TAXES: {sum.ToString("F2", CultureInfo.InvariantCulture)}\n");

        } // end Main()
    }// end Class
} // end Namespace
