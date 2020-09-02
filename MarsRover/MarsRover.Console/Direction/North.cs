using MarsRover.Console.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Console.Direction
{
    public class North : IDirection
    {
        private readonly ISurfaceArea _surfacearea;

        public North(ISurfaceArea surfacearea)
        {
            _surfacearea = surfacearea;
        }

        public IDirection RotateLeft()
        {
            return new West(_surfacearea);
        }

        public IDirection RotateRight()
        {
            return new East(_surfacearea);
        }

        public void Move()
        {
            _surfacearea.MoveYForward();
        }

        public override string ToString()
        {
            return "North";
        }
    }
}
