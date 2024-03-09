using Delivery.Order.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Order.SqlData.Mappings
{
    public class OrderItemMap : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable("ORDER");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.ProductId)
                .HasColumnName("PRODUCTID");

            builder.Property(u => u.Description)
                .HasColumnName("DESCRIPTION");

            builder.Property(u => u.Quantity)
               .HasColumnName("QUANTITY");

            builder.Property(u => u.Price)
                .HasColumnName("PRICE");
        }
    }
}
