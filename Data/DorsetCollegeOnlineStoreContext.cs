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
    }
}
