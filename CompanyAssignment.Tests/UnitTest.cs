using CompanyAssignment.Core;
using System.Collections.Generic;
using Xunit;

namespace CompanyAssignment.Tests
{
    public class SimulatorTests
    {
        private Simulator CreateSimulator(
            int width,
            int height,
            int startX,
            int startY)
        {
            var table = new Table(width, height);
            var robot = new Robot(new Position(startX, startY));
            return new Simulator(table, robot);
        }

        [Fact]
        public void Example_Input_Should_Return_Expected_Position()
        {
            var simulator = CreateSimulator(4, 4, 2, 2);

            var commands = new List<int> { 1, 4, 1, 3, 2, 3, 2, 4, 1, 0 };

            var result = simulator.Run(commands);

            Assert.NotNull(result);
            Assert.Equal(0, result!.X);
            Assert.Equal(1, result.Y);
        }

        [Fact]
        public void Moving_Outside_Table_Should_Return_Null()
        {
            var simulator = CreateSimulator(4, 4, 0, 0);

            var commands = new List<int> { 1, 0 }; // this should move north from [0,0]

            var result = simulator.Run(commands);

            Assert.Null(result);
        }

        [Fact]
        public void Quit_Immediately_Should_Return_Start_Position()
        {
            var simulator = CreateSimulator(4, 4, 1, 1);

            var commands = new List<int> { 0 };

            var result = simulator.Run(commands);

            Assert.NotNull(result);
            Assert.Equal(1, result!.X);
            Assert.Equal(1, result.Y);
        }

        [Fact]
        public void Backward_Movement_Should_Work_Correctly()
        {
            var simulator = CreateSimulator(4, 4, 2, 2);

            var commands = new List<int> { 2, 0 }; // this should move backward (south)

            var result = simulator.Run(commands);

            Assert.NotNull(result);
            Assert.Equal(2, result!.X);
            Assert.Equal(3, result.Y);
        }

        [Fact]
        public void Full_Rotation_Should_Return_To_North()
        {
            var simulator = CreateSimulator(4, 4, 2, 2);

            var commands = new List<int> { 3, 3, 3, 3, 1, 0 }; // this should rotate right 4 times (full rotation) and then move forward and end on [2,1]

            var result = simulator.Run(commands);

            Assert.NotNull(result);
            Assert.Equal(2, result!.X);
            Assert.Equal(1, result.Y);
        }
    }
}
