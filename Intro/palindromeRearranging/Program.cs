namespace palindromeRearranging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        bool solution(string inputString)
        {
            int[] arr = new int[26];

            int k = 0;
            foreach (char c in inputString)
            {
                arr[c - 'a']++;
                if(arr[c - 'a'] % 2 != 0)
                {
                    k++;
                }
                else
                {
                    k--;
                }
            }
            return k <= 1;

        }

    }
}
