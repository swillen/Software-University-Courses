using NewsSystem.Data.Migrations;
using NewsSystem.Models;

namespace NewsSystem.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class NewsContext : DbContext
    {
        // Your context has been configured to use a 'NewsContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'NewsSystem.Data.NewsContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'NewsContext' 
        // connection string in the application configuration file.
        public NewsContext()
            : base("NewsContext")
        {
            Database.SetInitializer
			(new MigrateDatabaseToLatestVersion<NewsContext,Configuration>());
        }
        public virtual DbSet<News> News { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}