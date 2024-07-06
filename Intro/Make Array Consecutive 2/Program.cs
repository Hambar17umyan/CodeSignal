namespace Make_Array_Consecutive_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        bool solution(int[] sequence)
        {
            int a = -1;

            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i - 1] >= sequence[i])
                {
                    a = i;
                    if (a > 1)
                    {
                        if (sequence[i - 2] < sequence[i])
                        {

                        }
                        else
                        {
                            sequence[i] = sequence[i - 1];
                        }
                    }

                    break;
                }
            }

            if (a == -1)
            {
                return true;
            }

            for (int i = a + 1; i < sequence.Length; i++)
            {
                if (sequence[i - 1] >= sequence[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
