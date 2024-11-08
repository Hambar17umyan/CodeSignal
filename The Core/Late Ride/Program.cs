namespace Late_Ride
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(808));
            int solution(int n)
            {
                int min = n % 60;
                int hour = n / 60;

                return min / 10 + min % 10 + hour / 10 + hour % 10; 
            }

        }
    }
}
