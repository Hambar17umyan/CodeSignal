namespace commonCharacterCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        int solution(string s1, string s2)
        {
            int[]count = new int[26];
            int res = 0;

            foreach (char c in s1)
            {
                count[c - 'a']++;
            }

            foreach (char c in s2)
            {
                if (count[c - 'a'] > 0)
                {
                    res++;
                    count[c - 'a']--;
                }
            }

            return res;
        }
    }
}
