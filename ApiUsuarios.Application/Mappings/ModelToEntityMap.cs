using ApiUsuarios.Domain.Models;
using AutoMapper;
using Delivery.Order.Application.Models;
using Delivery.Order.Domain.Models;

namespace ApiUsuarios.Application.Mappings
{
    public class ModelToEntityMap : Profile
    {
        public ModelToEntityMap()
        {
            CreateMap<CreateOrderPostModel, Order>();
            CreateMap<CreateOrderItemPostModel, OrderItem>();
        }
    }
}
