using MoviesDb.Data.Migrations;
using MoviesDb.Models;

namespace MoviesDb.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MoviesContext : DbContext
    {
       
        public MoviesContext()
            : base("name=MoviesContext")
        {

            Database.SetInitializer
            (new MigrateDatabaseToLatestVersion<MoviesContext, Configuration>());

            //  drops the database and create it again
            //Database.SetInitializer(new DropCreateDatabaseAlways<MoviesContext>());
        }

        
        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<User> Users{ get; set; }
        public virtual DbSet<Country>Countries  { get; set; }
		
        // protected override void OnModelCreating(DbModelBuilder modelBuilder)
        // {
            // modelBuilder.Entity<User>()
                // .HasMany(m => m.Movies)
                // .WithMany();

        // }
    }

   
}