using Microsoft.EntityFrameworkCore;
using ElijahbillpayerAPI.Models;
using Org.BouncyCastle.Asn1.Pkcs;

namespace ElijahbillpayerAPI.Data
{
    public class AppDbContext : DbContext
    {
        //Declare our context from entity framework
        private readonly AppDbContext _dbContext;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            _dbContext = this;
        }
        //Set all our models
        public DbSet<Admin> Admin { get; set; }
         public DbSet<Bills> Bills { get; set; }
        
        public DbSet<Payments> Payments { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Priviledges> Priviledges { get;set; }
        
    }
}
