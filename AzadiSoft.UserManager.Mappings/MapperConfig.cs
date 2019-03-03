using AutoMapper;
using AzadiSoft.UserManager.DomainModels;
using AzadiSoft.UserManager.ViewModels;

namespace AzadiSoft.UserManager.Mappings
{
    public class MapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(mapper =>
            {
                mapper.CreateMap<User, UserViewModel>();

                mapper.CreateMap<UserViewModel, User>();

            });
        }
    }
}