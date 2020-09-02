using MarsRover.Console.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Console.Commands
{
    class RotateLeftCommand:ICommand
    {
        public void Execute(IRover rover)
        {
            rover.RotateLeft();
        }
    }
}
