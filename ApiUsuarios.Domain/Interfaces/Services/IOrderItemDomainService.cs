using Delivery.Order.Domain.Models;

namespace Delivery.Order.Domain.Interfaces.Services
{
    public interface IOrderItemDomainService
    {
        void CreateOrder(OrderItem orderItem);
        void UpdateOrder(OrderItem orderItem);
        void DeleteOrder(OrderItem orderItem);
        OrderItem GetOrder(int id);
        List<OrderItem> GetAllOrders();
    }
}
