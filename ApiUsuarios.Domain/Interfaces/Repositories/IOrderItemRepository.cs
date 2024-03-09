using ApiUsuarios.Domain.Interfaces.Repositories;
using Delivery.Order.Domain.Models;

namespace Delivery.Order.Domain.Interfaces.Repositories
{
    public interface IOrderItemRepository : IBaseRepository<OrderItem, Guid>
    {

    }
}
