namespace Bishop_and_Pawn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool solution(string bishop, string pawn)
            {
                return Math.Abs(bishop[0] - pawn[0]) == Math.Abs(pawn[1] - bishop[1]);
            }

        }
    }
}
