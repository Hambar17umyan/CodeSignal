namespace Sort_by_Height
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        int[] solution(int[] a)
        {
            int[] sorted = new int[a.Length];
            int[] arr = new int[sorted.Length];

            Array.Copy(a, sorted, a.Length);
            Array.Sort(sorted);

            int j;
            for(j = 0; j<sorted.Length; j++)
            {
                if (sorted[j] != -1)
                    break;
            }
            for (int i = 0; i < sorted.Length; i++)
            {
                if(a[i] == -1)
                {
                    arr[i] = -1;
                }
                else
                {
                    arr[i] = sorted[j];
                    j++;
                }
            }
            return arr;
        }

    }
}
