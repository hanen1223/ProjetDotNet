using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configuuration
{
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>//ctrl+; pour implimenter interface
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.HasKey(f => f.FlightId);
            builder.ToTable("MyFlight");
            builder.Property(j => j.Departure).IsRequired().HasMaxLength(100).HasColumnName("ville de departure").HasDefaultValue("Tounes").HasColumnType("nchar");
            builder.HasOne(f => f.plane).WithMany(p => p.Flights).HasForeignKey(f=>f.PlaneFK).OnDelete(DeleteBehavior.SetNull);
          //  builder.HasMany(f=>f.passengers).WithMany(f => f.Flights).UsingEntity(p=>p.ToTable("My Reservation"));
            
        }
    }
    
}
