namespace Will_You
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(false,false,false));
            bool solution(bool young, bool beautiful, bool loved)
            {
                return !(young & beautiful == loved);
            }

        }
    }
}
