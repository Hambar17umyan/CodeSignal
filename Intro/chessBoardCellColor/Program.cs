namespace chessBoardCellColor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool solution(string cell1, string cell2)
            {
                int x1, y1, x2, y2;
                x1 = cell1[0] - 'A';
                y1 = cell1[1] - 'A';

                x2 = cell2[0] - 'A';
                y2 = cell2[1] - 'A';

                return (Math.Abs(x1 - x2) % 2 == Math.Abs(y1 - y2) % 2);
            }

        }
    }
}
