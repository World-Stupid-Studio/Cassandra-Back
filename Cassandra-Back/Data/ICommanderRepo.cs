﻿using Cassandra_Back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cassandra_Back.Data
{
    public interface ICommanderRepo
    {
        bool SaveChanges();

        IEnumerable<Command> GetAllCommands();

        Command GetCommandById(int id);

        void CreateCommand(Command cmd);
    }
}
