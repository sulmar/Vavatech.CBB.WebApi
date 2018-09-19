using CBB.Bankomat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBB.Bankomat
{
    class Program
    {
        static void Main(string[] args)
        {
            Scenario1Test();
        }

        private static void Scenario1Test()
        {

            IPrinter printer = new TermoPrinter();

            IATM atm1 = new PekaoATM("A545454", printer);

            try
            {
                Console.WriteLine("Podaj PIN");

                string pinCode = Console.ReadLine();

                bool isLogged = atm1.Login(pinCode);


                if (isLogged)
                {
                    Console.WriteLine("Podaj kwotę");

                    // decimal amount = decimal.Parse(Console.ReadLine());

                    if (decimal.TryParse(Console.ReadLine(), out decimal amount))
                    {
                        atm1.Deposit(amount);


                        decimal saldo = atm1.GetSaldo();

                        Console.WriteLine("Wypłata - Podaj kwotę");

                        amount = decimal.Parse(Console.ReadLine());

                        atm1.Widthraw(amount);


                    }
                    else
                    {
                        Console.WriteLine("Błędny format");
                    }



                    // Scenariusz #1
                    //  1. Wpłać 1000 zł

                    //  2. Sprawdz saldo

                    //  3. Wypłać 500 zł

                    //  4. Sprawdz saldo
                }
                else
                {
                    Console.WriteLine("Błędny PIN");
                }

            }

            catch (InvalidOperationException e)
            {
                Console.WriteLine($"ERROR: {e.Message}");
            }
            catch(NotSupportedException e)
            {
                Console.WriteLine("Wybrana funkcja jest niedostępna.");
            }

        }
    }
}
