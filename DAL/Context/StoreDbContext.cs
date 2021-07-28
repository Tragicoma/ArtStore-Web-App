using ArtStore.Entity;
using Microsoft.EntityFrameworkCore;


namespace ArtStore.DAL.Context
{
    public class StoreDbContext : DbContext
    {

        public DbSet<ProductDTO> Products { get; set; }
        public DbSet<PaintingAuthorDTO> Authors { get; set; }
        public DbSet<OrderDTO> Orders { get; set; }
        public DbSet<OrderLineDTO> OrderLines { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
       optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=ART-DB",
           options => options.EnableRetryOnFailure());

    }
}
