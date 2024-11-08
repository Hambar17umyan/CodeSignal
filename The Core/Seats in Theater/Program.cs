namespace Seats_in_Theater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int solution(int nCols, int nRows, int col, int row)
            {
                return (nCols - col + 1) * (nRows - row);
            }

        }
    }
}
