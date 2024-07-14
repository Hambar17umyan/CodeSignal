namespace growingPlant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int solution(int upSpeed, int downSpeed, int desiredHeight)
            {
                if(upSpeed >= desiredHeight)
                {
                    return 1;
                }
                desiredHeight -= upSpeed;
                return 1 + desiredHeight / (upSpeed - downSpeed) + (desiredHeight % (upSpeed - downSpeed) != 0 ? 1 : 0);
            }

        }
    }
}
