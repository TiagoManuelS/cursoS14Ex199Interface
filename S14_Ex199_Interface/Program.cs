using S14_Ex199_Interface.Entities;
using S14_Ex199_Interface.Services;
using System;
using System.Globalization;

namespace S14_Ex199_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime initialDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double totalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int parcelas = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, initialDate, totalValue);

            ContractService contractService = new ContractService(parcelas, new TaxCalculationService());

            contractService.ProcessInstallment(contract);

            Console.WriteLine("Installments");

            foreach (Installment installment in contract.list)
            {
                Console.WriteLine(installment.ToString());
            }




        }
    }
}
