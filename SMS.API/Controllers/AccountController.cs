using SMS.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;

namespace SMS.API.Controllers
{
    public class AccountController : Controller
    {
        // GET: api/Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        // GET: api/Login/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel ObjloginModel)
        {
            if (ModelState.IsValid == false)
                return View(ObjloginModel);

            return View();
        }

        // POST: api/Login
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/Login/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // DELETE: api/Login/5
        public void Delete(int id)
        {
        }
    }
}
