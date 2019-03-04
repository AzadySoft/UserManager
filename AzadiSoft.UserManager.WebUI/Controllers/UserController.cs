﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AzadiSoft.UserManager.Mappings;
using AzadiSoft.UserManager.Resources;
using AzadiSoft.UserManager.ServiceLayer;
using AzadiSoft.UserManager.ViewModels;
using AzadiSoft.UserManager.WebUI.Classes;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using StructureMap.Util;

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
            return RedirectToAction("List");
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

            model.Gender_ListItems = new List<SelectListItem>()
            {
                new SelectListItem() {Text = MessageText.SelectFromList, Value = ""},
                new SelectListItem() {Text = MessageText.Male, Value = "0"},
                new SelectListItem() {Text = MessageText.Female, Value = "1"}
            };
        }

        [HttpPost]
        public ActionResult Create(UserViewModel model)
        {
            try
            {
                model.DateCreated = DateTime.Now;

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
            var query = _userService.GetAllQueryable().ToList().Select(x => x.ToModel());

            var result = query.ToDataSourceResult(request);

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [ActionName("View")]
        public ActionResult ViewItem(int id)
        {
            UserViewModel model;

            var db = CacheServer.Database;

            var tableName = Consts.Users;

            var keyName = "User_" + id;

            if (db.HashExists(tableName, keyName))
            {
                model = CacheServer.GetFromTable<UserViewModel>(tableName, keyName); 
            }
            else
            {
                var user = _userService.GetByID(id);

                model = user.ToModel();

                CacheServer.AddToTable(tableName, keyName, model);
            }

            return PartialView("ViewItem", model);
        }

        public ActionResult IsUserNameRegistered(string userName)
        {
            var exists = _userService.GetAllQueryable(x => x.UserName == userName).Any();

            return Json(exists, JsonRequestBehavior.AllowGet);
        }

        public ActionResult IsEmailRegistered(string Email)
        {
            var exists = _userService.GetAllQueryable(x => x.Email == Email).Any();

            return Json(exists, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Edit(int id)
        {
            var user = _userService.GetByID(id);

            var model = user.ToModel();

            FillViewModelData(model);

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(UserViewModel model)
        {

            try
            {
                var original = _userService.GetByID(model.User_ID);

                _userService.Detach(original);

                var user = model.ToEntity();

                user.DateCreated = original.DateCreated;

                user.DateLastUpdated = DateTime.Now;

                if (!string.IsNullOrEmpty(model.Password))
                {
                    user.Password = original.Password;
                }

                _userService.Update(user);

                SuccessMessage(string.Format(MessageText.UserUpdated , user.UserName));

                return RedirectToAction("List");

            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message + "<br/>" + ex.InnerException?.Message + "<br/>" + ex.InnerException?.InnerException?.Message);

                FillViewModelData(model);

                return View(model);
            }

        }
    }
}