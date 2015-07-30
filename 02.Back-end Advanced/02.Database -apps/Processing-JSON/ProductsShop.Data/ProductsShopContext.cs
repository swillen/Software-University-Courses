using ProductsShop.Data.Migrations;
using ProductsShop.Models;

namespace ProductsShop.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ProductsShopContext : DbContext
    {
        
        public ProductsShopContext()
            : base("name=ProductsShopContext")
        {
            Database.SetInitializer
            (new MigrateDatabaseToLatestVersion<ProductsShopContext, Configuration>());

            // this drops the database and create it again
            //Database.SetInitializer(new DropCreateDatabaseAlways<ProductsShopContext>());
            
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Categorie> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(a => a.Friends)
                .WithMany()
                .Map(m =>
                {
                    m.MapLeftKey("UserId");
                    m.MapRightKey("FriendId");
                    m.ToTable("UserFriend");
                });

           

        }
    }

    
}