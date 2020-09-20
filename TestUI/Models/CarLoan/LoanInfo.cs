using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestUI.Models.CarLoan
{
    public class LoanInfo
    {
        public string LoanAcctId { get; set; }
        public string Amt { get; set; }
        public string AmtPeriod { get; set; }
        public string PayDD { get; set; }

        public static List<LoanInfo> GenList()
        {
            var result = new List<LoanInfo>();

            for (int i = 1; i <= 10; i++)
            {
                result.Add(Create($"101XXX{i:0000}", i));
            }

            return result;
        }

        public static LoanInfo Create(string loanAcctId, int i)
        {
            var rnd = new Random(int.Parse($"{DateTime.Now:mmssffff}") + i);

            return new LoanInfo()
            {
                LoanAcctId = loanAcctId,
                Amt = rnd.Next(10000, 100000).ToString(),
                AmtPeriod = rnd.Next(2000, 3000).ToString(),
                PayDD = rnd.Next(1, 30).ToString()
            };
        }
    }
}