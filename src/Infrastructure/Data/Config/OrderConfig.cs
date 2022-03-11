﻿using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(x => x.BuyerId).IsRequired().HasMaxLength(450);
            builder.OwnsOne(x => x.ShipToAddress, nb =>
            {
                nb.WithOwner();
                nb.Property(x => x.Country).IsRequired().HasMaxLength(90);
                nb.Property(x => x.State).IsRequired().HasMaxLength(60);
                nb.Property(x => x.City).IsRequired().HasMaxLength(100);
                nb.Property(x => x.Street).IsRequired().HasMaxLength(180);
                nb.Property(x => x.ZipCode).IsRequired().HasMaxLength(18);
            });
            builder.Navigation(x => x.ShipToAddress).IsRequired();
        }
    }
}
