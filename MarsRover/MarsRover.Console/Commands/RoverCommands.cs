using MarsRover.Console.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Console.Commands
{
    public static class RoverCommands
    {
        public static Dictionary<string, ICommand> List
        {
            get
            {
                var commands = new Dictionary<string, ICommand>
                    {
                        {"M", new RoverFarwordCommand()},
                        {"L", new RotateLeftCommand()},
                        {"R", new RotateRightCommand()}
                    };
                return commands;
            }
        }
    }
}