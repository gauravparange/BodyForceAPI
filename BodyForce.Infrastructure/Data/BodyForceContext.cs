using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyForceAPI
{
    public class BodyForceContext : DbContext
    {
        public BodyForceContext(DbContextOptions<BodyForceContext> option): base(option)
        {
                
        }
        public DbSet<Users> User { get; set; }
        public DbSet<MembershipPlans> Membership { get; set; }
        public DbSet<Memberships> Memberships { get; set; }
        public DbSet<Notifications> Notification { get; set; }
        public DbSet<Payments> Payment { get; set; }
        public DbSet<Roles> Roles { get; set; }
    }
}
