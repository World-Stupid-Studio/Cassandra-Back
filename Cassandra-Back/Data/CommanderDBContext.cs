using Cassandra_Back.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cassandra_Back.Data
{
    public class CommanderDBContext : DbContext
    {
        public CommanderDBContext(DbContextOptions<CommanderDBContext> opts) : base(opts) { }

        public DbSet<Command> Commands { get; set; }
    }
}
