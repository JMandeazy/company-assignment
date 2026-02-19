namespace CompanyAssignment.Core
{
    public class Table
    {
        public int Width { get; }
        public int Height { get; }

        public Table(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public bool IsInside(Position position)
        {
            return position.X >= 0 &&
                   position.Y >= 0 &&
                   position.X < Width &&
                   position.Y < Height;
        }
    }
}
