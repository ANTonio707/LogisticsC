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
        }
    }
}
