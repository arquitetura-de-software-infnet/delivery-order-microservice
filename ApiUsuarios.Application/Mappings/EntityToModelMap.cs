using ApiUsuarios.Domain.Models;
using AutoMapper;
using Delivery.Order.Application.Models;
using Delivery.Order.Domain.Models;

namespace ApiUsuarios.Application.Mappings
{
    public class EntityToModelMap : Profile
    {
        public EntityToModelMap()
        {
            CreateMap<Order, CreateOrderPostModel>();
            CreateMap<OrderItem, CreateOrderItemPostModel>();
        }
    }
}
