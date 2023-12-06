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
        public DbSet<Airtime> Airtime { get; set; }
        public DbSet<AirtimeActivity> Airtimeactivity { get; set; }
        public DbSet<Bills> Bills { get; set; }
        public DbSet<Cable> Cable { get; set; }
        public DbSet<CableActivity> Cableactivity { get; set; }
        public DbSet<DataActivity> Dataactivity { get; set; }
        public DbSet<Electrical> Electrical { get; set; }
        public DbSet<ElectricalActivity> Electricalactivity { get; set; }
        public DbSet<Payments> Payments { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Priviledge> Priviledge { get;set; }
        public DbSet <SmsVerify> Smsverify { get; set; }
        public DbSet <EmailVerify> EmailVerify { get; set; }
    }
}
