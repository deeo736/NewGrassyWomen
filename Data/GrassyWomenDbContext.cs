
using GrassyWomen.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;

namespace GrassyWomen.Data
{
    public class GrassyWomenDbContext: DbContext 
    {
        public DbSet<Product> Products { get; set; }
        
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public GrassyWomenDbContext() : base()
        {
        }

        public  GrassyWomenDbContext(DbContextOptions<GrassyWomenDbContext> options) : base(options)
        {
        }

       


    }


}
