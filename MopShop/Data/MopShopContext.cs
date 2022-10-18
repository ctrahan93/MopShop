using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MopShop.Models;

namespace MopShop.Data
{
    public class MopShopContext : DbContext
    {
        public MopShopContext (DbContextOptions<MopShopContext> options)
            : base(options)
        {
        }

        public DbSet<MopShop.Models.Mops> Mops { get; set; }
    }
}
