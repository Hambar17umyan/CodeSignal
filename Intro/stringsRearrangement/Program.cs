namespace stringsRearrangement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string[]> permutations;
            bool solution(string[] inputArray)
            {
                permutations = new List<string[]>();
                Array.Sort(inputArray);
                GeneratePermutations(inputArray, 0, inputArray.Length - 1);
                foreach (string[] s in permutations)
                {
                    bool succ = true;
                    for (int i = 1; i < s.Length; i++)
                    {
                        if (dif(s[i], s[i - 1]) != 1)
                        {
                            succ = false;
                            break;
                        }
                    }
                    if(succ)
                    {
                        return true;
                    }
                }

                return false;
            }

            void GeneratePermutations(string[] array, int start, int end)
            {
                if (start == end)
                {
                    // Add a copy of the array to the permutations list
                    string[] perm = new string[array.Length];
                    Array.Copy(array, perm, array.Length);
                    permutations.Add(perm);
                }
                else
                {
                    for (int i = start; i <= end; i++)
                    {
                        Swap(ref array[start], ref array[i]);
                        GeneratePermutations(array, start + 1, end);
                        Swap(ref array[start], ref array[i]); // backtrack
                    }
                }
            }

            void Swap(ref string a, ref string b)
            {
                string temp = a;
                a = b;
                b = temp;
            }
            int dif(string a, string b)
            {
                int res = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] != b[i])
                        res++;
                }
                return res;
            }

        }
    }
}