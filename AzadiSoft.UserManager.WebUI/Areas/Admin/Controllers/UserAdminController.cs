using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AzadiSoft.UserManager.Mappings;
using AzadiSoft.UserManager.ServiceLayer;
using AzadiSoft.UserManager.ViewModels;
using AzadiSoft.UserManager.WebUI.Controllers;
using StackExchange.Redis;

namespace AzadiSoft.UserManager.WebUI.Areas.Admin.Controllers
{
    public class UserAdminController : BaseController
    {
        private readonly IUser_Service _userService;

        public UserAdminController(IUser_Service userService)
        {
            _userService = userService;
        }

        // GET: Admin/UserAdmin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewUser(int id)
        {
            var redis = ConnectionMultiplexer.Connect(Settings.RedisCacheServer);

            var cache = redis.GetDatabase();

            var keyName = "User_" + id;

            UserViewModel model;

            if (cache.KeyExists(keyName))
            {
                var value = cache.StringGet(keyName);

                model = JavaScriptSerializer.Deserialize<UserViewModel>(value);
            }
            else
            {
                var user = _userService.GetByID(id);

                model = user.ToModel();

                var jsonData = JavaScriptSerializer.Serialize(model);

                cache.StringSet(keyName, jsonData);
            }

            return View(model);

        }
    }
}