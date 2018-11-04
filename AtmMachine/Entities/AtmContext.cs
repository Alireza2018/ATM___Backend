using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtmMachine.Entities
{
    public class AtmContext : DbContext
    {
        public AtmContext(DbContextOptions<AtmContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<UserDetails> UserDetails { get; set; }
        public DbSet<ProfileDetails> ProfileDetails { get; set; }
        public DbSet<GiftCardDetails> GiftCardDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
