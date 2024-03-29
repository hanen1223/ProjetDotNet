﻿using AM.ApplicationCore.Domain;
using AM.Infrastructure.Configuration;
using AM.Infrastructure.Configuuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
    public class AMContexte:DbContext
    {
        public DbSet<Flight> Flights { get; set; }//ctrl+;
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<test2> test2s { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Traveller> Travellers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Data Source=(localDB)\MsSqlLocalDb; initial catalog=HanenHammouda;Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* modelBuilder.Entity<Flight>().HasKey(f=>f.FlightId);
             modelBuilder.Entity<Flight>().ToTable("MyFlight");
             modelBuilder.Entity<Flight>().Property(j=>j.Departure).IsRequired().HasMaxLength(100).HasColumnName("ville de departure").HasDefaultValue("Tounes").HasColumnType("nchar");*/ //t7awlt l FlightConfiguration.cs
            modelBuilder.ApplyConfiguration(new FlightConfiguration());
            modelBuilder.ApplyConfiguration(new PassengerConfiguration());  
            modelBuilder.ApplyConfiguration(new TicketConfiguration());  
            modelBuilder.Entity<Passenger>().ToTable(nameof(Passenger));// ou chaine "" f blaset nameof
            modelBuilder.Entity<Traveller>().ToTable(nameof(Traveller));
            modelBuilder.Entity<Staff>().ToTable(nameof(Staff));
            //modelBuilder.Entity<test2>().ToTable(nameof(test2));



        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
           configurationBuilder.Properties<String>().HaveMaxLength(120);
           configurationBuilder.Properties<DateTime>().HaveColumnType("date");
           configurationBuilder.Properties<Double>().HavePrecision(2,3);
        }
    }
}
