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
            CreateMap<BasketDTO, BasketModel>();
            CreateMap<OrderDTO, OrderModel>();
            CreateMap<PaintingAuthorDTO,paintingAuthorModel>();
            CreateMap<PaintingDTO,PaintingModel>();
            CreateMap<ProductDTO, ProductModel>();
            CreateMap<OrderLineDTO, OrderLineModel>();
        }
    }
}
