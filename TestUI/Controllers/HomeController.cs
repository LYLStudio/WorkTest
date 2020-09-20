using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestUI.Models.CarLoan;

namespace TestUI.Controllers
{
    public class HomeController : Controller
    {
        // GET: CarLoan
        public ActionResult Index()
        {
            var model = new SetAgreementViewModel();
            model.AcctInfoList = AcctInfo.GenList();
            model.LoanInfoList = LoanInfo.GenList();

            return View(model);
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]        
        public ActionResult Index(List<AcctAgreementModel> model)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }

    public class AcctAgreementModel
    {
        public string AcctId { get; set; }
        public string LoanAcctId { get; set; }
    }
}