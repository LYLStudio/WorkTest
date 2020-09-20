using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestUI.Models.CarLoan
{
    public class AcctInfo
    {
        public string AcctId { get; set; }
        public string AcctName { get; set; }
        public string AcctType { get; set; }

        public static List<AcctInfo> GenList()
        {
            var result = new List<AcctInfo>();

            for (int i = 1; i <= 5; i++)
            {
                result.Add(Create($"ACCT101XXX{i:0000}"));

            }

            return result;
        }

        public static AcctInfo Create(string acctId)
        {
            return new AcctInfo()
            {
                AcctId = acctId,
                AcctName = $"Name{acctId}",
                AcctType = "ACCTTYPE"
            };
        }
    }
}