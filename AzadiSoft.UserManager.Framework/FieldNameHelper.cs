using System;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace AzadiSoft.UserManager.Framework
{
    public static class FieldNameHelper
    {
        public static string FieldNameFor<TModel, TValue>(this HtmlHelper<TModel> html,

            Expression<Func<TModel, TValue>> expression)
        {
            dynamic d = expression.Body;

            var memberName = d.Member.Name;

            var fieldName = memberName.ToString();

            return fieldName;
        }
    }
}