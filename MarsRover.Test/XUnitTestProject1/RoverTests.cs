using MarsRover.Console;
using MarsRover.Console.Direction;
using MarsRover.Console.Interface;
using System;
using Xunit;


namespace XUnitTestProject1
{
    public class RoverTests
    {
        private ISurfaceArea _surfacearea;
      
        public RoverTests()
        {
            _surfacearea = new SurfaceArea(5);
        }

        [Fact]
        public void When_Rover_Is_Created_Start_At_North()
        {
            var rover = new Rover(_surfacearea);
            Assert.IsType<North>(rover.Direction);
        }

        [Fact]
        public void When_Rover_Is_Created_And_Rotate_Left_The_Direction_Is_West()
        {
            var rover = new Rover(_surfacearea);
            rover.RotateLeft();
            Assert.IsType<West>(rover.Direction);
        }

        [Fact]
        public void When_Rover_Is_Created_And_Rotate_Right_The_Direction_Is_East()
        {
            var rover = new Rover(_surfacearea);
            rover.RotateRight();
            Assert.IsType<East>(rover.Direction);
        }

        [Fact]
        public void When_Rover_Is_Created_Is_Facing_North_And_Move_Rover_Will_Be_At_Coordinates_0_1()
        {
            var rover = new Rover(_surfacearea);
            rover.RoverForward();
            Assert.Equal(0, rover.CoordinateX);
            Assert.Equal(1, rover.CoordinateY);
        }

        [Fact]
        public void When_The_Rover_Is_Created_Rotate_Right_And_Move_Rover_Will_Be_At_Coordinates_1_0()
        {
            var rover = new Rover(_surfacearea);
            rover.RotateRight();
            rover.RoverForward();
            Assert.Equal(1, rover.CoordinateX);
            Assert.Equal(0, rover.CoordinateY);
        }

        [Fact]
        public void When_The_Rover_Is_Created_And_Move_So_That_Facing_South_And_Move_Coordinates_Will_Be_0_1()
        {
            var rover = new Rover(_surfacearea);
            rover.RoverForward();
            rover.RoverForward();
            rover.RotateRight();
            rover.RotateRight();
            Assert.IsType<South>(rover.Direction);
            rover.RoverForward();
            Assert.Equal(0, rover.CoordinateX);
            Assert.Equal(1, rover.CoordinateY);
        }

        [Fact]
        public void When_The_Rover_Is_Created_And_Move_So_That_Facing_West_And_Move_Coordinates_Will_Be_1_0()
        {
            var rover = new Rover(_surfacearea);
            rover.RotateRight();
            rover.RoverForward();
            rover.RoverForward();
            rover.RotateRight();
            rover.RotateRight();
            Assert.IsType<West>(rover.Direction);
            rover.RoverForward();
            Assert.Equal(1, rover.CoordinateX);
            Assert.Equal(0, rover.CoordinateY);
        }

        [Fact]
        public void When_Start_Move_Rotate_Rotate_Move_Back_To_Home_Coordindates()
        {
            var rover = new Rover(_surfacearea);
            rover.RoverForward();
            rover.RotateLeft();
            rover.RotateLeft();
            rover.RoverForward();
            Assert.Equal(0, rover.CoordinateX);
            Assert.Equal(0, rover.CoordinateY);
        }

        [Theory]
        [InlineData("RMLMMRM", 2, 2, "East")]
        [InlineData("RMLLM", 0, 0, "West")]
        public void TestMovement(string commandString, int xCoordinateExpected, int yCoordinateExpected, string directionExpected)
        {
            var rover = new Rover(_surfacearea);
            rover.ExecuteCommands(commandString);
            Assert.Equal(xCoordinateExpected, rover.CoordinateX);
            Assert.Equal(yCoordinateExpected, rover.CoordinateY);
            Assert.Equal(directionExpected, rover.Direction.ToString());
        }
    }
}