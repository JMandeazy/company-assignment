using System;
using System.Linq;
using System.Reflection.Emit;
using CompanyAssignment.Core;
class Program
{
    static void Main()
    {
        var input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
            return;

        var numbers = input.Split(',')
                           .Select(int.Parse)
                           .ToList();

        if (numbers.Count < 4)
            return;

        var table = new Table(numbers[0], numbers[1]);
        var startPosition = new Position(numbers[2], numbers[3]);
        var robot = new Robot(startPosition);
        var simulator = new Simulator(table, robot);

        var commands = numbers.Skip(4);

        var result = simulator.Run(commands);

        if (result == null)
            Console.WriteLine("[-1, -1]");
        else
            Console.WriteLine($"[{result.X}, {result.Y}]");
    }
}
