using ApiUsuarios.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiUsuarios.Domain.Interfaces.Services
{
    public interface IOrderDomainService 
    {
        void CreateOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(Order order);
        Order GetOrder(int id);
        List<Order> GetAllOrders();
    }
}
