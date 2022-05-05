/*
 Dorset College Dublin
 BSc in Science in Computing & Multimedia
 Object-Oriented Programming - BSC20921
 Stage 2, Semester 2
 Continuous Assessment 2
 
 Student Name: Mateus Fonseca Campos
 Student Number: 24088
 Student Email: 24088@student.dorset-college.ie
 
 Submission date: 8 May 2022
*/

#nullable disable

using Microsoft.EntityFrameworkCore;

namespace DorsetCollegeOnlineStore.Data
{
    public class DorsetCollegeOnlineStoreContext : DbContext
    {
        public DorsetCollegeOnlineStoreContext(DbContextOptions<DorsetCollegeOnlineStoreContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Product> Product { get; set; }

        public DbSet<Models.User> User { get; set; }

        public DbSet<Models.Cart> Cart { get; set; }

        public DbSet<Models.Order> Order { get; set; }

        public DbSet<Models.CartProduct> CartProduct { get; set; }

        public DbSet<Models.OrderProduct> OrderProduct { get; set; }
    }
}