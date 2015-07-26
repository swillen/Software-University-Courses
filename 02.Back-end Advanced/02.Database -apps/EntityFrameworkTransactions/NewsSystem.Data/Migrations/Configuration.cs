using NewsSystem.Models;

namespace NewsSystem.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NewsSystem.Data.NewsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "NewsSystem.Data.NewsContext";
        }

        protected override void Seed(NewsSystem.Data.NewsContext context)
        {
            
            context.News.AddOrUpdate(n=>n.Content,new News()
            {
                Content = "EF 7 Beta To Be Released in May 2016"
            });
            context.News.AddOrUpdate(n => n.Content, new News()
            {
                Content = "Second article"
            });
            context.News.AddOrUpdate(n=>n.Content,new News()
            {
                Content = "Third article"
            });
            context.SaveChanges();
        }
        
    }
}
