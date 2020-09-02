using MarsRover.Console.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Console.Commands
{
    class RoverFarwordCommand:ICommand
    {
        public void Execute(IRover rover)
        {
            rover.RoverForward();
        }
    }
}
