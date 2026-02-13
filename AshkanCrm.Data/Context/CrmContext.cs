using Microsoft.EntityFrameworkCore;

namespace MyCrm.Web
{
    public class CrmContext : DbContext
    {
        public CrmContext(DbContextOptions<CrmContext> options)
            : base(options)
        {
        }

        // نمونه:
        // public DbSet<Customer> Customers { get; set; }
    }
}
