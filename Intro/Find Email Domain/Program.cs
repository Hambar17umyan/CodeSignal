namespace Find_Email_Domain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string solution(string address)
            {
                return address.Substring(address.LastIndexOf('@') + 1);
            }

        }
    }
}
