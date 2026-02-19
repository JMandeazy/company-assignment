namespace CompanyAssignment.Core
{
    public class Position
    {
        public int X { get; }
        public int Y { get; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Position Move(int deltaX, int deltaY)
        {
            return new Position(X + deltaX, Y + deltaY);
        }
    }
}
