using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KushanShop.Models;

namespace kushanShop.Data
{
    public class kushanShopContext : DbContext
    {
        public kushanShopContext (DbContextOptions<kushanShopContext> options)
            : base(options)
        {
        }

        public DbSet<KushanShop.Models.Shop> Shop { get; set; }
    }
}
