using ApiUsuarios.Domain.Interfaces.Repositories;
using ApiUsuarios.Domain.Models;

namespace ApiUsuarios.Domain.Interfaces.Repositories
{
    public interface IOrderRepository : IBaseRepository<Order, Guid>
    {

    }
}
