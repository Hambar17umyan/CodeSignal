namespace areEquallyStrong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool solution(int yourLeft, int yourRight, int friendsLeft, int friendsRight)
            {
                return Math.Max(yourLeft, yourRight) == Math.Max(friendsLeft, friendsRight) && Math.Min(yourLeft, yourRight) == Math.Min(friendsLeft, friendsRight);
            }
        }


    }
}
