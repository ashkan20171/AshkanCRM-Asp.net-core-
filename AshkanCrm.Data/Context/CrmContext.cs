using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AshkanCRM.Domain.Entities.Account;
using Microsoft.EntityFrameworkCore;
using MyCrm.Domain.Entities.Account;

namespace AshkanCRM.Data.Context
{
    public class CrmContext : DbContext
    {
        public CrmContext(DbContextOptions<CrmContext> options) : base(options)
        {

        }

        #region DB Set

        public DbSet<User> Users { get; set; }
        public DbSet<Marketer> Marketers { get; set; }
        public DbSet<Customer> Customers { get; set; }

        #endregion
    }
}
