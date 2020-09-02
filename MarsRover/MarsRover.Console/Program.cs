using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Console;
using MarsRover.Console.Interface;

namespace MarsRover.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ISurfaceArea surfacearea = new SurfaceArea(5);
            Rover rover = new Rover(surfacearea);
            System.Console.WriteLine(rover.ToString());
            string commandsToExecute = string.Empty;
            while (commandsToExecute != "E")
            {
                System.Console.Write("Enter Commands: ");
                commandsToExecute = System.Console.ReadLine().ToUpper();
                rover.ExecuteCommands(commandsToExecute);
                System.Console.WriteLine();
                System.Console.WriteLine(string.Format("Current Rover Position Heading: {0}", rover.ToString()));
            }
        }
    }

}
