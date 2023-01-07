using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
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
