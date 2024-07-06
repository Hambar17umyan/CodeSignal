namespace Are_Similar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[]{1, 2, 3};
            int[] arr1 = new int[]{2, 1, 3};

            var a = solution(arr, arr1);

            Console.WriteLine(a);

            bool solution(int[] a, int[] b)
            {
                int i1, i2;
                i1 = i2 = -1;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] != b[i])
                    {
                        if (i1 == -1)
                        {
                            i1 = i;
                        }
                        else if (i2 == -1)
                        {
                            i2 = i;
                        }
                        else return false;
                    }
                }
                if (i1 == -1)
                    return true;
                if (i2 == -1)
                    return false;

                return ((a[i1] == b[i2] && a[i2] == b[i1]));
            }

        }
    }
}
