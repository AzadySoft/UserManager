using System.Web.Script.Serialization;
using StackExchange.Redis;

namespace AzadiSoft.UserManager.WebUI.Classes
{
    public static class CacheServer
    {
        private static IDatabase _database = null;

        private static IConnectionMultiplexer _multiplexer = null;

        public static JavaScriptSerializer JavaScriptSerializer = new JavaScriptSerializer();

        public static IConnectionMultiplexer Multiplexer
        {
            get
            {
                if (_multiplexer == null || !_multiplexer.IsConnected)
                {
                    _multiplexer = ConnectionMultiplexer.Connect(Settings.RedisCacheServer);

                }

                return _multiplexer;
            }
        }

        public static IDatabase Database
        {
            get
            {                
                if (_database == null)
                {
                    _database = Multiplexer.GetDatabase();
                }

                return _database;
            }
        }

        public static T Get<T>(string keyName, T defaultValue = null) where T : class
        {
            if (Database.KeyExists(keyName))
            {
                string strValue = Database.StringGet(keyName);

                var obj = JavaScriptSerializer.Deserialize<T>(strValue);

                return obj;
            }
            else
            {
                if (defaultValue != null)
                {
                    var strValue = JavaScriptSerializer.Serialize(defaultValue);

                    Database.StringSet(keyName, strValue);                    
                }

                return defaultValue;
            }
        }

        public static void Set<T>(string keyName, T value) where T : class
        {
            var jsonData = JavaScriptSerializer.Serialize(value);

            Database.StringSet(keyName, jsonData);
        }

        public static void Set(string keyName, string value)
        {
            Database.StringSet(keyName, value);
        }

        public static void AddToTable<T>(string tableName, string keyName, T value) where T : class
        {
            var jsonData = JavaScriptSerializer.Serialize(value);

            Database.HashSet(tableName, keyName, jsonData);
        }

        public static T GetFromTable<T>(string tableName, string keyName, T defaultValue = null) where T : class
        {
            if (Database.HashExists(tableName, keyName))
            {
                string strValue = Database.HashGet(tableName, keyName);

                var obj = JavaScriptSerializer.Deserialize<T>(strValue);

                return obj;
            }
            else
            {
                if (defaultValue != null)
                {
                    var strValue = JavaScriptSerializer.Serialize(defaultValue);

                    Database.HashSet(tableName, keyName, strValue);
                }

                return defaultValue;
            }

        }
    }
}