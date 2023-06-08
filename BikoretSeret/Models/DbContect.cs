using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikoretSeret.Models
{
    public class DbContect : DbContext
    {
        public DbSet<TbUser> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data source=Demo.db");
        public DbSet<Movie> movies { get; set; }
        public DbSet<Comments> comments { get; set; }


    }
}
