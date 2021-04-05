using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Banking.Models;
using BankingLib;

namespace Banking.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Verify()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Verify(Login lg)
        {
            LoginDAL lgdal = new LoginDAL();

            if(lgdal.VerifyData(lg))
            {
                return View("LoginSuccess");
            }
            else
            {
                return View("LoginFailure");
            }

        }
    }
}