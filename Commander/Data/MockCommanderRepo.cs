using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {

                new  Command {Id=0, Howto="Boild and egg", Line="Boil Warter",Platfom="Kettle and pand"},
                new  Command {Id=1, Howto="Cut bread", Line="Get a knife",Platfom="Kettle and pand"},
                new  Command {Id=2, Howto="cup of tea", Line="Get a tea bag",Platfom="Kettle and pand"}

            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
           return new Command {Id=0, Howto="Boild and egg", Line="Boil Warter",Platfom="Kettle and pand"};
        }
    }

}