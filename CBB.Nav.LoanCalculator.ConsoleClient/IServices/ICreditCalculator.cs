using CBB.Nav.LoadCalculator.ConsoleClient.Models;
using CBB.Nav.LoanCalculator.ConsoleClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBB.Nav.LoanCalculator.ConsoleClient.IServices
{
    public interface ICreditCalculator
    {
        CreditResponse Calculate(CreditRequest creditRequest);
    }
}
