using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using global::Commander.Data;
using global::Commander.Models;
using Microsoft.AspNetCore.Mvc;
//using Commander.Models;

namespace Commander.Controllers
{
    //api/commands
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;

        public CommandsController(ICommanderRepo repository)
        {
            _repository = repository;
        }
        //Get api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commands = _repository.GetAllCommands();
            return Ok(commands);
        }
        //GEt api/commands/5
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
           var commandItem = _repository.GetCommandById(id);
           return Ok(commandItem);
        }
    }
}