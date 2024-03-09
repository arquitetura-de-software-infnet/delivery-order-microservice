using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiUsuarios.Domain.Models
{
    public class Order
    {
        public Guid? Id { get; set; }
        public Guid? UserId { get; set; }
        public int PaymentMethod { get; set; }
        public decimal Total { get; set; }
    }
}
