using AshkanCrm.Domain.Entities.Account;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace MyCrm.Web
{
    public class CrmContext : DbContext
    {
        public CrmContext(DbContextOptions<CrmContext> options)
            : base(options)
        {
        }

        #region DB Set

        public DbSet<User> Users { get; set; }

        public DbSet<Marketer> Marketers { get; set; }

        public DbSet<Customer> Customers { get; set; }

        #endregion

    }
}