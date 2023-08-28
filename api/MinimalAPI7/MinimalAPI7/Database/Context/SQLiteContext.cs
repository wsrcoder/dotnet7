using Microsoft.EntityFrameworkCore;
using MinimalAPI7.Models;
using System.Reflection;

namespace MinimalAPI7.Database.Context
{
    public class SQLiteContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("DataSource=./Database/Data/Blog.db");
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Post[] postsToSeed = new Post[1000];
            Random rand = new Random();

            for(int i=0; i < 1000; i++)
            {
                int randNum = rand.Next(1, 10);
                postsToSeed[i] = new Post
                {
                    Id = i + 1,
                    Title = $"Post {i+1} - Número Randomico: {randNum}",
                    Content = $" {i+1} multiplicado por {randNum}: {(i+1)*randNum}",
                    CreatedAt = DateTime.Now,
                };
            }

            modelBuilder.Entity<Post>().HasData(postsToSeed);
        }
    }
}
