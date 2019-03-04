using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AzadiSoft.UserManager.WebUI.Classes;
using AzadiSoft.UserManager.WebUI.Models;
using StackExchange.Redis;
using Telerik.Windows.Documents.Spreadsheet.Expressions.Functions;

namespace AzadiSoft.UserManager.WebUI.Controllers
{
    public class CacheController : BaseController
    {
        // GET: Cache
        public ActionResult Index()
        {

            string value = CacheServer.Database.HashGetAll("a")[0].Value;

            return View();
        }

        public ActionResult Products()
        {
            var products = GetProductsFromFile();

            var tableName = "Products";

            var database = CacheServer.Database;            

            foreach (var product in products)
            {
                var keyName = "Product_" + product.Id;

                var jsonData = JavaScriptSerializer.Serialize(product);

                database.HashSet(tableName, keyName, jsonData);
            }

            return Json(products, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetProduct(int id)
        {
            var database = CacheServer.Database;

            string json = database.HashGet("Products", "Product_" + id);

            var product = JavaScriptSerializer.Deserialize<ProductModel>(json);

            return Json(product, JsonRequestBehavior.AllowGet);
        }

        private List<ProductModel> GetProductsFromFile()
        {
            var fileName = Server.MapPath("~/App_Data/ProductsData.json");

            var products = DeserializeFromFile<List<ProductModel>>(fileName);
            return products;
        }
    }
}