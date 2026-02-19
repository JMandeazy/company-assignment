namespace CompanyAssignment.Core
{
    public class Robot
    {
        public Position Position { get; private set; }
        public Direction Direction { get; private set; }

        public Robot(Position startPosition)
        {
            Position = startPosition;
            Direction = Direction.North;
        }

        public void RotateClockwise()
        {
            Direction = (Direction)(((int)Direction + 1) % 4);
        }

        public void RotateCounterClockwise()
        {
            Direction = (Direction)(((int)Direction + 3) % 4);
        }

        public Position GetForwardPosition()
        {
            return Direction switch
            {
                Direction.North => Position.Move(0, -1),
                Direction.East => Position.Move(1, 0),
                Direction.South => Position.Move(0, 1),
                Direction.West => Position.Move(-1, 0),
                _ => Position
            };
        }

        public Position GetBackwardPosition()
        {
            return Direction switch
            {
                Direction.North => Position.Move(0, 1),
                Direction.East => Position.Move(-1, 0),
                Direction.South => Position.Move(0, -1),
                Direction.West => Position.Move(1, 0),
                _ => Position
            };
        }

        public void MoveTo(Position newPosition)
        {
            Position = newPosition;
        }
    }
}
