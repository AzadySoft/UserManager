using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using AzadiSoft.UserManager.Resources;

namespace AzadiSoft.UserManager.WebUI.Controllers
{
    public abstract class BaseController : Controller
    {
        public JavaScriptSerializer JavaScriptSerializer = new JavaScriptSerializer();

        public T DeserializeFromFile<T>(string fileName) where T: class
        {
            var fileContent = System.IO.File.ReadAllText(fileName);

            var data = JavaScriptSerializer.Deserialize<T>(fileContent);

            return data;
        }

        public void SuccessMessage(string msg)
        {
            TempData[Consts.SuccessMessage] = msg;
        }

        public void ErrorMessage(string msg)
        {
            TempData[Consts.ErrorMessage] = msg;
        }

    }
}