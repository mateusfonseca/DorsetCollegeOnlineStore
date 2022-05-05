#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DorsetCollegeOnlineStore.Models;

namespace DorsetCollegeOnlineStore.Data
{
    public class DorsetCollegeOnlineStoreContext : DbContext
    {
        public DorsetCollegeOnlineStoreContext (DbContextOptions<DorsetCollegeOnlineStoreContext> options)
            : base(options)
        {
        }

        public DbSet<DorsetCollegeOnlineStore.Models.Product> Product { get; set; }

        public DbSet<DorsetCollegeOnlineStore.Models.User> User { get; set; }

        public DbSet<DorsetCollegeOnlineStore.Models.Cart> Cart { get; set; }

        public DbSet<DorsetCollegeOnlineStore.Models.Order> Order { get; set; }

        public DbSet<DorsetCollegeOnlineStore.Models.CartProduct> CartProduct { get; set; }

        public DbSet<DorsetCollegeOnlineStore.Models.OrderProduct> OrderProduct { get; set; }
    }
}
