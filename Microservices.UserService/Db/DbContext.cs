using Microservices.UserService.Db.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.UserService.Db
{
    public class DBContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
            (@"
            data source=.;
            database=UserService;
            persist security info=True;
            user id=SqlServer;
            password=Him@@123;
            ");
        }
    }
}
