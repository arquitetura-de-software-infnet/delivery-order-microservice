using ApiUsuarios.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiUsuarios.SqlData.Mappings
{
    public class OrderMap : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("ORDER");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.UserId)
                .HasColumnName("USERID");

            builder.Property(u => u.PaymentMethod)
                .HasColumnName("PAYMENTMETHOD");

            builder.Property(u => u.Total)
               .HasColumnName("TOTAL");
        }
    }
}
