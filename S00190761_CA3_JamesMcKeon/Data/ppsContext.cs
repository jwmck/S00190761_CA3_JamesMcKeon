using S00190761_CA3_JamesMcKeon.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S00190761_CA3_JamesMcKeon.Data
{
    public class ppsContext : DbContext
    {

        public ppsContext(DbContextOptions<ppsContext> options)
      : base(options)
        {
        }

        public DbSet<ppsItem> ppsItems { get; set; }
    }
}
