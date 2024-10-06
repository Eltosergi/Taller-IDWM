using api.src.Models;
using Microsoft.EntityFrameworkCore;

namespace api.src.Data
{
    public class ApplicationDBContext(DbContextOptions dbContextOptions):DbContext(dbContextOptions)
    {
        public DbSet<User> Users { get; set; } = null;
        public DbSet<Role> Roles { get; set; } = null;
        public DbSet<Product> Products { get; set; } =  null;
        public DbSet<Buy> Buys { get; set; } = null;
        public DbSet<Ticket> Tickets { get; set; } = null;
    }

   
}