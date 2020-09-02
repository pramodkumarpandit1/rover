using MarsRover.Console.Interface;

namespace MarsRover.Console.Direction
{
    public class West : IDirection
    {
        private readonly ISurfaceArea _surfacearea;

        public West(ISurfaceArea surfacearea)
        {
            _surfacearea = surfacearea;
        }

        public IDirection RotateLeft()
        {
            return new South(_surfacearea);
        }

        public IDirection RotateRight()
        {
            return new North(_surfacearea);
        }

        public void Move()
        {
            _surfacearea.MoveXBackward();
        }

        public override string ToString()
        {
            return "West";
        }
    }
}