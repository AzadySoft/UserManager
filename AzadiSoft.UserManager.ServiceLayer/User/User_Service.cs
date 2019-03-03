using AzadiSoft.UserManager.DataLayer;
using AzadiSoft.UserManager.DomainModels;

namespace AzadiSoft.UserManager.ServiceLayer
{
    public class User_Service : GenericService<User> , IUser_Service
    {
        public User_Service(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
    }
}