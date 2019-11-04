using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace UserSubscription.Models
{
    public class SubscriptionContext: DbContext
    {
        public SubscriptionContext(DbContextOptions<SubscriptionContext> options) : base(options) { }
        public DbSet<Subscription> Subscriptions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Subscription>().HasData(new Subscription() { Id = 1, FirstName = "John", LastName = "Doe", Email = "john@doe.com", Gender = Gender.Male, Agreed = true, Confirmed = true, ConfirmationCode = "FGC12556", CountryCode = "CZ" });
        }
    }
}
