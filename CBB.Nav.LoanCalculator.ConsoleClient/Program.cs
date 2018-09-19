using CBB.Nav.LoadCalculator.ConsoleClient.Models;
using CBB.Nav.LoanCalculator.ConsoleClient.IServices;
using CBB.Nav.LoanCalculator.ConsoleClient.Models;
using CBB.Nav.LoanCalculator.ConsoleClient.Services;
using System;
namespace CBB.Navigator.PexCalculator.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            InterfaceTest();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }


        static void InterfaceTest()
        {
            ICreditCalculator creditCalculator = new FakeCreditCalculator();
            
            CreditRequest creditRequest = new CreditRequest(1000, 100);

            CreditResponse creditResponse = creditCalculator.Calculate(creditRequest);

            // UI

            Console.WriteLine($"Amount: {creditResponse.Amount}");

        }

    }
}
