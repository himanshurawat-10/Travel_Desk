using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDesk_Entities;

namespace DAL
{
    public class TravelDbContext : DbContext
    {
        public TravelDbContext()
        {

        }
        public TravelDbContext(DbContextOptions<TravelDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=INW-922\\SQLEXPRESS;initial catalog=TravelDeskDb;integrated security=true;TrustServerCertificate=true");

        }


    }
}
