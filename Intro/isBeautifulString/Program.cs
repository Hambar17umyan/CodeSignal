namespace isBeautifulString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool solution(string inputString)
            {
                int[] Appears = new int[26];
                foreach(char c in inputString)
                {
                    Appears[c - 'a']++;
                }
                for(int i = 1; i < Appears.Length; i++)
                {
                    if (Appears[i] > Appears[i - 1])
                        return false;
                }
                return true;
            }

        }
    }
}
