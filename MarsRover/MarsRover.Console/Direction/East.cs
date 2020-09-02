using MarsRover.Console.Interface;

namespace MarsRover.Console.Direction
{
    public class East : IDirection
    {
        private readonly ISurfaceArea _surfacearea;

        public East(ISurfaceArea surfacearea)
        {
            _surfacearea = surfacearea;
        }

        public IDirection RotateLeft()
        {
            return new North(_surfacearea);
        }

        public IDirection RotateRight()
        {
            return new South(_surfacearea);
        }

        public void Move()
        {
            _surfacearea.MoveXForward();
        }

        public override string ToString()
        {
            return "East";
        }
    }
}