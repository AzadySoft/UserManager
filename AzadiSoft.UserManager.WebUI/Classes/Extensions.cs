using System;
using System.Globalization;
using System.Linq;

namespace AzadiSoft.UserManager.WebUI.Classes
{
    public static class Extensions
    {
        public static string ToPersianDateTime(this DateTime? date, bool containsYear = true, bool containsMonth = true, bool containsDay = true, bool fullTime = false)
        {
            if (date != null)
            {
                string persianDateTime = "";
                PersianCalendar pc = new PersianCalendar();
                if (fullTime)
                {
                    persianDateTime = (containsYear ? pc.GetYear((DateTime)date) + "/" : " ") + (containsMonth ? pc.GetMonth((DateTime)date) + "/" : "") + (containsDay ? pc.GetDayOfMonth((DateTime)date) + "" : "") + " " + ((DateTime)date).ToString("hh:mm:ss tt");
                }
                else
                {
                    persianDateTime = (containsYear ? pc.GetYear((DateTime)date) + "/" : " ") + (containsMonth ? pc.GetMonth((DateTime)date) + "/" : "") + (containsDay ? pc.GetDayOfMonth((DateTime)date) + "" : "");
                }
                return persianDateTime;
            }
            else return "";
        }

        public static DateTime ToDateTime(this string persianDateTime)
        {
            PersianCalendar pc = new PersianCalendar();
            var dateParts = GetDateParts(persianDateTime);
            DateTime dt = pc.ToDateTime(dateParts[0], dateParts[1], dateParts[2], 0, 0, 0, 0, 0);
            return dt;
        }

        public static int[] GetDateParts(string persianDate)
        {
            return persianDate.Split('/').Select(datePart => int.Parse(datePart)).ToArray();
        }
    }
}