using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Order.Application.Models
{
    public class CreateOrderPostModel
    {
        public Guid? Id { get; set; }
        public Guid? UserId { get; set; }
        public int PaymentMethod { get; set; }
        public decimal Total { get; set; }
    }
}
