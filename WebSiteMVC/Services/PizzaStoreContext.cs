using Microsoft.EntityFrameworkCore;
using WebSiteMVC.Models;

namespace WebSiteMVC.Services
{
    public class PizzaStoreContext : DbContext
    {
        public PizzaStoreContext(DbContextOptions<PizzaStoreContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<Pizza> AppBanner { get; set; }

    }
}
