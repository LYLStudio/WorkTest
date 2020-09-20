using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TestUI.Models.CarLoan
{
    public class SetAgreementViewModel
    {
        [DisplayName("活存帳號")]
        public List<AcctInfo> AcctInfoList { get; set; }
        [DisplayName("貸款帳號")]
        public List<LoanInfo> LoanInfoList { get; set; }

        [DisplayName("設定清單")]
        public List<Dictionary<string,string>> BindingInfoList { get; set; }
    }
}