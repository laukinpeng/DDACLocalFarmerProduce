using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DDACLocalFarmerProduce.Models;

namespace DDACLocalFarmerProduce.Data
{
    public class DDACProductContext : DbContext
    {
        public DDACProductContext (DbContextOptions<DDACProductContext> options)
            : base(options)
        {
        }

        public DbSet<DDACLocalFarmerProduce.Models.Product> Product { get; set; }
    }
}
