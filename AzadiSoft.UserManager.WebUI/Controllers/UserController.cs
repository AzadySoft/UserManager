using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AzadiSoft.UserManager.Mappings;
using AzadiSoft.UserManager.Resources;
using AzadiSoft.UserManager.ServiceLayer;
using AzadiSoft.UserManager.ViewModels;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;

namespace AzadiSoft.UserManager.WebUI.Controllers
{
    public class UserController : BaseController
    {

        #region Constructor

        private readonly IUser_Service _userService;

        private readonly IRole_Service _roleService;

        private readonly IEducationLevel_Service _educationLevelService;


        public UserController(IUser_Service userService, IRole_Service role_Service,
            IEducationLevel_Service educationLevel_Service)
        {
            _userService = userService;

            _roleService = role_Service;

            _educationLevelService = educationLevel_Service;

        }

        #endregion

        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            return View();
        }

        public ActionResult Create()
        {
            var model = new UserViewModel();

            FillViewModelData(model);

            return View(model);
        }

        private void FillViewModelData(UserViewModel model)
        {
            model.RoleListItems = _roleService.GetSelectListItems();

            model.EducationLevelListItems = _educationLevelService.GetSelectListItems();
        }

        [HttpPost]
        public ActionResult Create(UserViewModel model)
        {
            try
            {
                var entity = model.ToEntity();

                _userService.Insert(entity);

                TempData[Consts.SuccessMessage] = string.Format(MessageText.UserSuccessfullySignUp, model.UserName);

                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {

                TempData[Consts.ErrorMessage] = ex.Message;

                FillViewModelData(model);

                return View(model);

            }
        }

        public ActionResult Grid_Read([DataSourceRequest] DataSourceRequest request)
        {
            var query = _userService.GetAllQueryable();

            var result = query.ToDataSourceResult(request);

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}