using AutoMapper;
using AzadiSoft.UserManager.DomainModels;
using AzadiSoft.UserManager.ViewModels;

namespace AzadiSoft.UserManager.Mappings
{
    public static class MappingExtensions
    {
        public static UserViewModel ToModel(this User entity)
        {
            var model = Mapper.Map<User, UserViewModel>(entity);

            return model;
        }

        public static User ToEntity(this UserViewModel model)
        {
            var entity = Mapper.Map<UserViewModel, User>(model);

            return entity;
        }
    }
}