using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AzadiSoft.UserManager.WebUI.Controllers;

namespace AzadiSoft.UserManager.WebUI.Areas.Admin.Controllers
{
    public class UserAdminController : BaseController
    {
        // GET: Admin/UserAdmin
        public ActionResult Index()
        {
            return View();
        }
    }
}