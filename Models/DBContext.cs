using System;
using Microsoft.EntityFrameworkCore;
using MovieTime.Models;


namespace MovieTime.Models {
    public class DBContext : DbContext {
        public DBContext(DbContextOptions options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlite("Filename=mydb.db");
        }
        public DbSet<User> Users {get;set;}

    }
}
