using System.Data.Entity.ModelConfiguration.Conventions;
using BookShopSystem.Data.Migrations;
using BookShopSystem.Models;

namespace BookShopSystem.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BookShopContext : DbContext
    {
       
        public BookShopContext()
            : base("name=BookShopContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BookShopContext,Configuration>());
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>(); // zabranqva kaskadno triene

            modelBuilder.Entity<Book>()
                .HasMany(r => r.RelatedBooks)
                .WithMany()
                .Map(m=>
                {
                    m.MapLeftKey("Book_Id");
                    m.MapRightKey("RelatedBook_id");
                    m.ToTable("BooksRelatedBooks");

                });
            base.OnModelCreating(modelBuilder);
        }
    }

  
}