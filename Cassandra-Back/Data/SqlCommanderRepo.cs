using Cassandra_Back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cassandra_Back.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderDBContext _context;
        public SqlCommanderRepo(CommanderDBContext context)
        {
            _context = context;
        }
        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(C => C.Id == id);
        }
    }
}
