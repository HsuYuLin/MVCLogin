using MVCLogin.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLogin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpPost]
        public ActionResult Create(LoginViewModel model)
        {
            //var model = new LoginViewModel();

            if (this.ModelState.IsValid)
            {
                model.Message = "恭喜你登入完成！";
                return View(model);
            }
            else
            {
                model.Message = "登入失敗，請重新登入！";
                return View(model);
                //return RedirectToAction("Index");
            }            
        }
        
        public ActionResult Index()
        {        
           return View();
        }
    }
}