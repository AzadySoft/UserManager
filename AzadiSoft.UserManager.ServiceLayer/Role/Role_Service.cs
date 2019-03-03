using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AzadiSoft.UserManager.DataLayer;
using AzadiSoft.UserManager.DomainModels;

namespace AzadiSoft.UserManager.ServiceLayer
{
    public class Role_Service : GenericService<Role>, IRole_Service
    {
        public Role_Service(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public IList<SelectListItem> GetSelectListItems()
        {
            var list = GetAllQueryable().ToList();

            var listItems = list.Select(x => new SelectListItem() {Text = x.TitleFa, Value = x.Role_ID.ToString()}).ToList();

            return listItems;
        }
    }
}