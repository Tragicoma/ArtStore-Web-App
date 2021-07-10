using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ArtStore.Entity;
using ArtStore.Ui.Models;

namespace ArtStore.Ui.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<BasketModel, BasketDTO>();
            CreateMap<OrderModel, OrderDTO>();
            CreateMap<paintingAuthorModel, PaintingAuthorDTO>();
            CreateMap<PaintingModel, PaintingDTO>();
            CreateMap<PrintModel, PrintDTO>();
            CreateMap<ProductModel, ProductDTO>();
        }
    }
}
