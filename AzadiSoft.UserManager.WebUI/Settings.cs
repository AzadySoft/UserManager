using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace AzadiSoft.UserManager.WebUI
{
    public class Settings
    {
        public static string RedisCacheServer => WebConfigurationManager.AppSettings["RedisCacheServer"];
    }
}