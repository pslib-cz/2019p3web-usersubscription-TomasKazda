using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace UserSubscription.Models
{
    public class SubsriptionDbContext: DbContext
    {
        public SubsriptionDbContext(DbContextOptions<SubsriptionDbContext> opt) : base(opt)
        {
            
        }

        public DbSet<Subscription> Subscriptions { get; set; }
    }
}
