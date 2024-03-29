﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Order.Application.Models
{
    public class CreateOrderItemPostModel
    {
        public Guid? Id { get; set; }
        public Guid? ProductId { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public int Quantity { get; set; }
    }
}
