namespace Valid_Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool solution(string time)
            {
                var arr = time.Split(':');

                if (arr.Length != 2 || arr[0].Length != 2 || arr[1].Length != 2)
                    return false;

                try
                {
                    int a;
                    int b;
                    a = int.Parse(arr[0]);
                    b = int.Parse(arr[1]);

                    return (a >= 0 && a < 24) && (b >= 0 && b < 60);
                }
                catch
                {
                    return false;
                }
            }

        }
    }
}
