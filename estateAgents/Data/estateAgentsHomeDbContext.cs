using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using estateAgents.Models;

namespace estateAgents.Data
{
    public class estateAgentsHomeDbContext : DbContext
    {
        public estateAgentsHomeDbContext (DbContextOptions<estateAgentsHomeDbContext> options)
            : base(options)
        {
        }

        public DbSet<estateAgents.Models.House> House { get; set; } = default!;
    }
}
