using CBB.Nav.LoadCalculator.ConsoleClient.Models;
using CBB.Nav.LoanCalculator.ConsoleClient.IServices;
using CBB.Nav.LoanCalculator.ConsoleClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBB.Nav.LoanCalculator.ConsoleClient.Services
{
    public class FakeCreditCalculator : ICreditCalculator
    {
        public CreditResponse Calculate(CreditRequest creditRequest)
        {
            return new CreditResponse { Amount = 1000 };
        }


        public void DoWork()
        {

        }
    }
}
