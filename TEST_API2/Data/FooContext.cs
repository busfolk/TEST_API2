using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnderstandingASPNETCore2x.Data.Entities;

namespace UnderstandingASPNETCore2x.Data
{
    public class FooContext : DbContext
    {
        public FooContext(DbContextOptions<FooContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
