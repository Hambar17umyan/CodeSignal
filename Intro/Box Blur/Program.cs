namespace Box_Blur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] solution(int[][] image)
            {
                int[][] res = new int[image.Length - 2][];

                for (int i = 0; i < res.Length; i++) 
                {
                    res[i] = new int[image[0].Length - 2];
                }

                for (int i = 1; i < image.Length - 1; i++)
                {
                    for (int j = 1; j < image[i].Length - 1; j++)
                    {
                        res[i - 1][j - 1] = Avarage(image[i][j], image[i][j + 1], image[i][j - 1], image[i + 1][j], image[i + 1][j + 1], image[i + 1][j - 1], image[i - 1][j], image[i - 1][j - 1], image[i - 1][j + 1]);
                    }
                }

                return res;
            }
            int Avarage(params int[] arr)
            {
                int res = 0;
                for(int i = 0; i < arr.Length; i++)
                {
                    res += arr[i];
                }
                return res / arr.Length;
            }
        }
    }
}
