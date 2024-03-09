using Delivery.Order.Application.Models;

namespace Delivery.Notification.Application.Interfaces
{
    public interface IOrderAppService
    {
        void CreateOrder(CreateOrderPostModel model);
        void UpdateOrder(CreateOrderPostModel model);
        void DeleteOrder(CreateOrderPostModel model);
    }
}
