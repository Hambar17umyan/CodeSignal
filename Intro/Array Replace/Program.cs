namespace Array_Replace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] solution(int[] inputArray, int elemToReplace, int substitutionElem)
            {
                for(int i = 0; i < inputArray.Length; i++)
                {
                    if(inputArray[i] == elemToReplace)
                        inputArray[i] = substitutionElem;
                }
                return inputArray;
            }

        }
    }
}
