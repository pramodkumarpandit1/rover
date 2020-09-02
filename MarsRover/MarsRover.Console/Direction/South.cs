using MarsRover.Console.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Console.Direction
{
    public class South : IDirection
    {
        private readonly ISurfaceArea _surfacearea;

        public South(ISurfaceArea surfacearea)
        {
            _surfacearea = surfacearea;
        }

        public IDirection RotateLeft()
        {
            return new East(_surfacearea);
        }

        public IDirection RotateRight()
        {
            return new West(_surfacearea);
        }

        public void Move()
        {
            _surfacearea.MoveYBackward();
        }

        public override string ToString()
        {
            return "South";
        }
    }
}