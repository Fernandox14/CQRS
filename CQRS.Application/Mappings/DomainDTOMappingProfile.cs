using AutoMapper;
using CQRS.Application.DTOS;
using CQRS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.Mappings
{
    public class DomainDTOMappingProfile : Profile
    {
        public DomainDTOMappingProfile()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
        }
    }
}
