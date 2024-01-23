using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    // This particular class we're going to derive from an EntityFramework class to get the functionality we need
    // DbContext allows us to abstract ourselves away from the database, we don't query the database directly
    // And that's responsible for translating our C# code into SQL specific queries that our database understands
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {
        }

        // DbSet represents a table in our database
        public DbSet<Product> Products { get; set; }
    }
}