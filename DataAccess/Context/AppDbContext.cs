using DataAccess.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Valyuta> Valyutas { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=WIN-VD08C7OPT8H\\SQLEXPRESS; Database=CurrencyAPIDB69;Trusted_Connection=true; Encrypt=false;");
        //}
    }
}
