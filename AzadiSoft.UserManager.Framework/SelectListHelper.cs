using System;
using System.Collections.Generic;
using System.Web.Mvc;
using AzadiSoft.UserManager.Resources;

namespace AzadiSoft.UserManager.Framework
{
    public static class SelectListHelper
    {
        public static void AddNonSelectedListItem(this IList<SelectListItem> selectList)
        {
            var item = new SelectListItem(){Text = MessageText.SelectFromList, Value = string.Empty};

            selectList.Insert(0, item);
        }
    }
}