using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSuiBeauty.Data;

namespace WebSuiBeauty.Controllers
{
    public class AccountController : Controller
    {
        WebSuiBeautyDbContext db = new WebSuiBeautyDbContext();
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Login(FormCollection formColl)
        //{
        //    string usrName = formColl["UserName"];
        //    string Pass = formColl["Password"];

        //    if (ModelState.IsValid)
        //    {
        //        var cust = (from m in db.Customers
        //                    where (m.UserName == usrName && m.Password == Pass)
        //                    select m).SingleOrDefault();

        //        if (cust != null)
        //        {
        //            TempShpData.UserID = cust.CustomerID;
        //            Session["username"] = cust.UserName;
        //            return RedirectToAction("Index", "Home");
        //        }

        //    }
        //    return View();
        //}
    }
}