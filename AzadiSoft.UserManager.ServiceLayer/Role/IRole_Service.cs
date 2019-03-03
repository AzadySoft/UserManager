using System.Collections.Generic;
using System.Web.Mvc;
using AzadiSoft.UserManager.DomainModels;

namespace AzadiSoft.UserManager.ServiceLayer
{
    public interface IRole_Service : IGenericService<Role>
    {
        IList<SelectListItem> GetSelectListItems();

    }
}