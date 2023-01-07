using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        /// <summary>
        /// Store Context
        /// </summary>
        /// <param name="options"></param>
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        /// <summary>
        /// Database set for products
        /// </summary>
        public DbSet<Product> Products { get; set; }
    }
}
