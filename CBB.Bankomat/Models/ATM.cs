using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBB.Bankomat.Models
{

    public interface IATM
    {
        bool Login(string pincode);
        void Widthraw(decimal amount);
        void Deposit(decimal amount);
        decimal GetSaldo();
    }


    public interface IDeposit
    {
        void Deposit(decimal amount);
    }

    public interface IWidthraw
    {
        void Widthraw(decimal amount);
    }

    public interface ISaldo
    {
        decimal GetSaldo();
    }

    public interface IAuthorize
    {
        bool Login(string pincode);
    }


    public class MyATM : IWidthraw, ISaldo, IAuthorize, IDeposit
    {
        private decimal saldo;

        public void Deposit(decimal amount)
        {
            throw new NotImplementedException();
        }

        public decimal GetSaldo()
        {
            return saldo;
        }

        public bool Login(string pincode)
        {
            throw new NotImplementedException();
        }

        public void Widthraw(decimal amount)
        {
            saldo -= amount;
        }
    }

    public interface IPrinter
    {
        void Print(string message);
    }


    public class LaserPrinter : IPrinter
    {
        public void Print(string message)
        {
            Console.WriteLine($"Printing on laser {message}...");
        }
    }

    public class TermoPrinter : IPrinter
    {
        private void Init()
        {
            Console.WriteLine("Nagrzewanie");
        }

        public void Print(string message)
        {
            Init();

            Console.WriteLine($"Printing on termo {message}...");
        }
    }

   
    public class PekaoATM : IATM
    {
        private string serialNumber;

        private decimal saldo;

        private IPrinter printer;

        public PekaoATM(string serialNumber, IPrinter printer)
        {
            this.serialNumber = serialNumber;
            this.printer = printer;
        }

        public void Deposit(decimal amount)
        {
            saldo += amount;

            Trace.WriteLine($"Wpłacono {amount:C2}");

            printer.Print($"PRINT: Wpłacono {amount:C2}");
        }

        public decimal GetSaldo()
        {
            return saldo;
        }

        public bool Login(string pincode)
        {
            return pincode == "1234";
        }

        public void Widthraw(decimal amount)
        {
            if (saldo >= amount)
            {
                saldo -= amount;

                Trace.WriteLine($"Wypłacono {amount:C2}");
                printer.Print($"PRINT: Wypłacono {amount:C2}");
            }
            else
            {
                printer.Print($"PRINT: Brak środków w bankomacie");
                throw new InvalidOperationException("Brak środków w bankomacie");
            }
        }
    }

    public class IngATM : IATM
    {

        private decimal saldo;

        public void Deposit(decimal amount)
        {
            throw new NotSupportedException();
        }

        public decimal GetSaldo()
        {
            return saldo;
        }

        public bool Login(string pincode)
        {
            return pincode == "1234";
        }

        public void Widthraw(decimal amount)
        {
            saldo -= amount;
        }
    }


    // Scenariusz #1
    //  1. Wpłać 1000 zł
    //  2. Sprawdz saldo
    //  3. Wypłać 500 zł
    //  4. Sprawdz saldo

    // komunikaty:
    // Wpłacono XXXX zł na konto YYYYYYYYY
    // Wypłacono XXXX zł z konta YYYYYYYYY
    // Stan konta YYYYYYY wynosi XXXX zł


}
