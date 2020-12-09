using Cassandra_Back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cassandra_Back.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAppCommands();

        Command GetCommandById(int Id);
    }
}
