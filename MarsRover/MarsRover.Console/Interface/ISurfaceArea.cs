using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Console.Interface
{
    public interface ISurfaceArea
    {
        int CoordinateX { get; }
        int CoordinateY { get; }
        void MoveXForward();
        void MoveXBackward();
        void MoveYForward();
        void MoveYBackward();
    }
}
