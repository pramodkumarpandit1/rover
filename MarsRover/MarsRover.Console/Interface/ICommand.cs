using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Console.Interface
{
    public interface ICommand
    {
        void Execute(IRover rover);
    }
}
