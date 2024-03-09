using Delivery.Order.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Order.Application.Interfaces
{
    public interface IOrderItemAppService
    {
        CreateOrderItemPostModel CreateOrder(CreateOrderItemPostModel model);
        void UpdateOrder(CreateOrderItemPostModel model);
        void DeleteOrder(CreateOrderItemPostModel model);
    }
}
