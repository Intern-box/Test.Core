namespace Test.Core
{
    public class Program
    {
        public static void Main()
        {
            if (DateTime.IsLeapYear(DateTime.Now.Year))
            {
                Console.WriteLine("високосный");
            }
            else
            {
                Console.WriteLine("НЕ високосный");
            }
        }
    }
}