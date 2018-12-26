using System;
using System.Collections.Generic;
using System.Text;
using HotelManagementSystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelManagementSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<RoomType> RoomType { get; set; }
        public DbSet<Booking> Booking { get; set; }
        public DbSet<Payment> Payment { get; set; }
        
    }
}
