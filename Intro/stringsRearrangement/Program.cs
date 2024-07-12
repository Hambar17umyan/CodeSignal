namespace stringsRearrangement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[5];
            for (int i = 0; i < 5; i++)
            {
                arr[i] = Console.ReadLine();
            }

            
            Console.WriteLine(solution(arr));
            bool solution(string[] inputArray)
            {
                Array.Sort(inputArray);
            }
            
        }
    }
}
