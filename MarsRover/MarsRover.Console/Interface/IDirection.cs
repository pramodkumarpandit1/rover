using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Console.Interface
{
    public interface IDirection
    {
        IDirection RotateLeft();
        IDirection RotateRight();
        void Move();
    }
}
