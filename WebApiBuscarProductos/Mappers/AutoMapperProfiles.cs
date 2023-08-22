using AutoMapper;
using WebApiBuscarProductos.Application.Dto;
using WebApiBuscarProductos.Domain;

namespace WebApiBuscarProductos.Mappers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {

            CreateMap<ProductoEntity, BuscarProductosDto>().ReverseMap();
            CreateMap<ProductoEntity, ProoductosDto>().ReverseMap();


        }
    }
}
 