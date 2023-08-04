


using Microsoft.EntityFrameworkCore;
using MauiSqLiteConnection.Models;
using MauiSqLiteConnection.Utilities;

namespace MauiSqLiteConnection.DataAcess
{
    public class DatabaseAcessContext: DbContext

    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionDB = $"FileName={PathDB.GetPath("test.db")}";
            optionsBuilder.UseSqlite(connectionDB);
        }
    }
}
