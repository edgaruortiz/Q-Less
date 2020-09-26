using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Q_Less.Controllers
{
    public class TransactionController : Controller
    {
        // GET: Transaction
        public ActionResult New()
        {
            return View();
        }
        [Route("Success")]
        public ActionResult Success()
        {
            return View("TransactionSuccess");
        }
    }
}