using MarsRover.Console.Interface;
using System.Collections.Generic;

namespace MarsRover.Console.Commands
{
    public class RCommandParser
    {
        private readonly Dictionary<string, ICommand> _commands;

        public RCommandParser(Dictionary<string, ICommand> commands)
        {
            _commands = commands;
        }

        public ICommand ParseCommand(string command)
        {
            if (_commands.ContainsKey(command))
            {
                return _commands[command];
            }

            return new RoverNotFoundCommand();
        }
    }
}
