using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBB.Nav.LoadCalculator.ConsoleClient.Models
{

    public class CreditRequest
    {
        public CreditRequest(decimal income, decimal limit)
        {
            Income = income;
            Limit = limit;
        }

        public decimal Income { get; set; }
        public decimal Limit { get; set; }

        public int Adults { get; set; }
        public int Childrens { get; set; }


        

        // ...
    }
}
