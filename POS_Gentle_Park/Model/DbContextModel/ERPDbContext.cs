using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Gentle_Park.Model
{
    public class ERPDbContext : DbContext
    {
        public ERPDbContext() : base("name=DefaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
        public virtual DbSet<MemberShip_Card_Master> MemberShip_Card_Master { get; set; }
        public virtual DbSet<Membership_CardList_Details> Membership_CardList_Details { get; set; }
    }
}

