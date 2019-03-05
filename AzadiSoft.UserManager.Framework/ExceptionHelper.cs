using System;

namespace AzadiSoft.UserManager.Framework
{
    public static class ExceptionHelper
    {
        public static string BR = "<br/>" + Environment.NewLine;

        public static string GetExceptionFullTraceMessage(this Exception ex)
        {
            string msg =  "<p><b>" + ex.Message + "</b>" + BR + "Source: " + BR + ex.StackTrace + BR + "</p>";

            if (ex.InnerException != null)
            {
                msg += GetExceptionFullTraceMessage(ex.InnerException);
            }

            return msg;
        }
    }
}