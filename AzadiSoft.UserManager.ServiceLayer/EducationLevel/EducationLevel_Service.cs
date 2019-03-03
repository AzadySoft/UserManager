using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AzadiSoft.UserManager.DataLayer;
using AzadiSoft.UserManager.DomainModels;

namespace AzadiSoft.UserManager.ServiceLayer
{
    public class EducationLevel_Service : GenericService<EducationLevel> , IEducationLevel_Service
    {
        public EducationLevel_Service(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public IList<SelectListItem> GetSelectListItems()
        {
            var list = GetAllQueryable().ToList();

            var listItems = list.Select(x => new SelectListItem() { Text = x.Title, Value = x.ID.ToString() }).ToList();

            return listItems;

        }
    }
}