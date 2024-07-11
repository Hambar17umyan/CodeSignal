namespace isIPv4Address
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool solution(string inputString)
            {
                string[] arr = inputString.Split('.');

                if (arr.Length != 4)
                    return false;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Length > 3)
                        return false;
                    if (string.IsNullOrEmpty(arr[i]))
                        return false;
                    if (arr[i][0] == '0' && arr[i].Length > 1)
                        return false;
                    bool success = int.TryParse(arr[i], out int k);
                    if (!success)
                        return false;
                    if(k >= 256 || k < 0)
                        return false;
                }

                return true;
            }

        }
    }
}
