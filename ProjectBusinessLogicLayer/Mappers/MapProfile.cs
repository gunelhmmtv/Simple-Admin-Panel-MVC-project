using AutoMapper;
using ProjectBusinessLogicLayer.DTOs;
using ProjectEntities.Concrete.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBusinessLogicLayer.Mappers
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ProductViewDto>();

            CreateMap<ProductAddDto, Product>().ReverseMap();
        }
    }
}
