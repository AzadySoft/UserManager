using System.Collections.Generic;
using System.Web.Mvc;
using AzadiSoft.UserManager.DomainModels;

namespace AzadiSoft.UserManager.ServiceLayer
{
    public interface IEducationLevel_Service : IGenericService<EducationLevel>
    {
        IList<SelectListItem> GetSelectListItems();
    }
}