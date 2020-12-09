using Cassandra_Back.Data;
using Cassandra_Back.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cassandra_Back.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly MockCommanderRepo _repository = new MockCommanderRepo();

        // GET /api/command
        [HttpGet]
        ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var commandList = _repository.GetAppCommands();

            return Ok(commandList);
        }

        // GET /api/command/{id}
        [HttpGet("{id}")]
        ActionResult <Command> GetCommandById(int id)
        {
            var command = _repository.GetCommandById(id);

            return Ok(command);
        }
    }
}
