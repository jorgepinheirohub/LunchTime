using Application.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) 
            : base(options)
        { }

        public DbSet<Restaurant> Restaurants { get; set; }

        public DbSet<User> Users { get; set; }
    }
}