using Microsoft.EntityFrameworkCore;
using ShopOnlineSmart.WebApp.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopOnlineSmart.WebApp.Models
{
    public class LoginDbContext : DbContext
    {
        //public LoginDbContext(DbContextOptions/*<ShopOnlineDbContext>*/ options) : base(options)
        //{
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=VUONGPHAM\\PHAMXUANVUONG;Database=ShopOnlineSmart;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        public DbSet<Login> Logins { get; set; }

        
    }
}
