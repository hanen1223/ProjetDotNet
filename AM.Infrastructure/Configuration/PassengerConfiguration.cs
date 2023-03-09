using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configuration
{
    public class PassengerConfiguration : IEntityTypeConfiguration<Passenger>// ctrl+;
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
            builder.OwnsOne(p => p.fillName, f => {
                f.Property(h => h.FirstName).IsRequired().HasMaxLength(30);
                f.Property(h => h.LastName).IsRequired().HasMaxLength(30).HasColumnName("lastname");
                });//type de tenu ==owns
            builder.HasDiscriminator<int>("type").HasValue<Passenger>(0).HasValue<Staff>(2).HasValue<Traveller>(5).HasValue<test2>(6);
        }
    }
}
