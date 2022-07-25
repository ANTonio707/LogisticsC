using AutoMapper;
using LogisticsCenterMODELS.Models;
using LogisticsCenterMODELS.Models.DTOModels;

namespace LogisticsCenterAPI.Utls
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() {

            CreateMap<Invoice, InvoiceDTO>().ReverseMap();

            CreateMap<User, UserLoginDTO>().ReverseMap();
            CreateMap<Supplier, SupplierDTO>().ReverseMap();
            CreateMap<External_User, External_UserDTO>().ReverseMap();



            //EXTERNAL USER
            CreateMap<External_UserDTO, External_User_RegisterDTO>().ReverseMap();
            CreateMap<External_User, External_User_RegisterDTO>().ReverseMap();
            CreateMap<External_User, External_UserDTO>().ReverseMap();

        }
    }
}
