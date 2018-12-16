using AutoMapper;
using ShareIt.Data.Auth.Entities;

namespace ShareIt.WebApi.Authentication.ViewModels.Mappings
{
    public class RegistrationViewModelToUser : Profile
    {
        public RegistrationViewModelToUser()
        {
            CreateMap<RegistrationViewModel, User>().ForMember(au => au.UserName, map => map.MapFrom(vm => vm.Email));
        }
    }
}
