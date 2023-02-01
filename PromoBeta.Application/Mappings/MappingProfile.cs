using AutoMapper;
using PromoBeta.Application.DTOs;
using PromoBeta.Domain.Entities;

namespace PromoBeta.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
        }
    }
}