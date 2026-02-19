using System.Collections.Generic;
using System.Reflection.Emit;

namespace CompanyAssignment.Core
{
    public class Simulator
    {
        private readonly Table _table;
        private readonly Robot _robot;

        public Simulator(Table table, Robot robot)
        {
            _table = table;
            _robot = robot;
        }

        public Position? Run(IEnumerable<int> commands)
        {
            foreach (var command in commands)
            {
                switch (command)
                {
                    case 0:
                        return _robot.Position;

                    case 1:
                        if (!TryMove(_robot.GetForwardPosition()))
                            return null;
                        break;

                    case 2:
                        if (!TryMove(_robot.GetBackwardPosition()))
                            return null;
                        break;

                    case 3:
                        _robot.RotateClockwise();
                        break;

                    case 4:
                        _robot.RotateCounterClockwise();
                        break;
                }
            }

            return _robot.Position;
        }

        private bool TryMove(Position newPosition)
        {
            if (!_table.IsInside(newPosition))
                return false;

            _robot.MoveTo(newPosition);
            return true;
        }
    }
}
