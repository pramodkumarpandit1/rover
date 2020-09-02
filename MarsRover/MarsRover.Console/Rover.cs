using MarsRover.Console.Commands;
using MarsRover.Console.Direction;
using MarsRover.Console.Interface;
using System;

namespace MarsRover.Console
{
    public class Rover : IRover
    {
        private readonly ISurfaceArea _surfacearea;

        public IDirection Direction { get; private set; }

        public Rover(ISurfaceArea surfacearea)
        {
            _surfacearea = surfacearea;
            Direction = new North(_surfacearea);
        }

        public void RotateLeft()
        {
            Direction = Direction.RotateLeft();
        }

        public void RotateRight()
        {
            Direction = Direction.RotateRight();
        }

        public void RoverForward()
        {
            Direction.Move();
        }
        public int CoordinateX => _surfacearea.CoordinateX;

        public int CoordinateY => _surfacearea.CoordinateY;

        public override string ToString()
        {
            return $"X : {CoordinateX}, Y : {CoordinateY}, Direction : {Direction}";
        }


        public void ExecuteCommands(string commandString)
        {
            try
            {
                var commands = RoverCommands.List;
                var commandParser = new RCommandParser(commands);

                for (int index = 0; index < commandString.Length; index++)
                {
                    string command = commandString[index].ToString();
                    var commandToExecute = commandParser.ParseCommand(command);
                    commandToExecute.Execute(this);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}
