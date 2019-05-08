using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace S00190761_CA3_JamesMcKeon.Models
{
    public class ChildContext : DbContext
    {

        public ChildContext(DbContextOptions<ChildContext> options)
            : base(options)
        { }


        public DbSet<Child> Children { get; set; }

    }
}
