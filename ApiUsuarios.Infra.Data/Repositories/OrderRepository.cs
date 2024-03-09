using ApiUsuarios.Infra.Data.Repositories;
using ApiUsuarios.Domain.Interfaces.Repositories;
using ApiUsuarios.Domain.Models;

namespace ApiUsuarios.SqlData.Repositories
{
    public class OrderRepository : BaseRepository<Order, Guid>, IOrderRepository
    {

    }
}
