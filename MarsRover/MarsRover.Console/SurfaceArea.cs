using MarsRover.Console.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Console
{
   public class SurfaceArea: ISurfaceArea
    {
        public int CoordinateX { get; private set; }
        public int CoordinateY { get; private set; }
        private readonly int _gridSize;

        public SurfaceArea(int gridSize)
        {
            CoordinateX = 0;
            CoordinateX = 0;
            _gridSize = gridSize;
        }

        public void MoveXForward()
        {
            if (CoordinateX < _gridSize)
                CoordinateX++;
        }

        public void MoveXBackward()
        {
            if (CoordinateX > 0)
                CoordinateX--;
        }

        public void MoveYForward()
        {
            if (CoordinateY < _gridSize)
                CoordinateY++;
        }

        public void MoveYBackward()
        {
            if (CoordinateY > 0)
                CoordinateY--;
        }
    }
}
