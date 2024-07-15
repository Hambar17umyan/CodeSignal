namespace File_Naming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] solution(string[] names)
            {
                int n = names.Length;
                int m = 0;
                for (int i = 0; i < n; i++)
                {
                    int sum = 0;
                    while (true)
                    {
                        int sum1 = sum;
                        for (int j = 0; j < i; j++)
                        {
                            if (names[j] == names[i])
                            {
                                sum++;
                                if (sum == 1)
                                {
                                    names[i] = names[i] + $"({sum})";
                                }
                                else
                                {
                                    names[i] = names[i].Substring(0, names[i].Length - 2 - ((sum - 1).ToString().Length));
                                    names[i] = names[i] + $"({sum})";
                                }
                                break;
                            }
                        }
                        if (sum1 == sum)
                            break;
                    }
                }
                return names;
            }

        }
    }
}
