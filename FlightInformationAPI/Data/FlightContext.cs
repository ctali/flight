using FlightInformationAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FlightInformationAPI.Data
{
    public class FlightContext : DbContext
    {
        public FlightContext(DbContextOptions<FlightContext> options) : base(options)
        {
        }

        public DbSet<Flight> Flights { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed data 
        }
    }
}