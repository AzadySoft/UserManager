using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AzadiSoft.UserManager.ServiceLayer;
using AzadiSoft.UserManager.ViewModels;

namespace AzadiSoft.UserManager.WebUI.Controllers
{
    public class UserController : BaseController
    {

private readonly IUser_Service _userService;
readonly IRole_Service _roleService;
readonly IEducationLevel_Service _educationLevelService;


public UserController(IUser_Service userService, IRole_Service role_Service, IEducationLevel_Service educationLevel_Service)
{
    _userService = userService;
    
    _roleService = role_Service;
    
    _educationLevelService = educationLevel_Service;

}

        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            var model = new UserViewModel();

            model.RoleListItems = _roleService.GetSelectListItems();

            model.EducationLevelListItems = _educationLevelService.GetSelectListItems();

            return View(model);
        }

        [HttpPost]
        public ActionResult Create(UserViewModel model)
        {
            throw new NotImplementedException();
            
        }
    }
}