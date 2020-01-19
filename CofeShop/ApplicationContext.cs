using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace CofeShop.Models
{
    class ApplicationContext : DbContext
    {
        private DbContextOptionsBuilder<ApplicationContext> options;

        public DbSet<Good>Goods { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public ApplicationContext(DbContextOptionsBuilder<ApplicationContext> options)
        {
            this.options = options;
        }
    }
}
