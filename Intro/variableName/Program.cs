namespace variableName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool solution(string name)
            {
                if (isDigit(name[0]))
                    return false;
                foreach(char c in name)
                {
                    if(!isDigit(c) && !isLetter(c) && !isUnderscore(c))
                    {
                        return false;
                    }
                }
                return true;
            }

            bool isDigit(char c)
            {
                return c >= '0' && c <= '9';
            }

            bool isLetter(char c)
            {
                return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
            }

            bool isUnderscore(char c)
            {
                return c == '_';
            }

        }
    }
}
