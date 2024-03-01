using Application.Features.Brands.Commands.CreateBrand;
using Application.Features.Brands.DTOs;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            //Mapleme profilleri yazılır
            CreateMap<Brand, CreatedBrandDto>().ReverseMap();
            CreateMap<Brand, CreateBrandCommand>().ReverseMap();//Tam tersi işlemlerde de kullanabilmek için reverse eklenir
        }
    }
}
