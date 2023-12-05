namespace Test.Core
{
    public class Program
    {
        public static void Main()
        {
            if (DateTime.Now.Month == 2)                            // Если февраль
            {
                if (DateTime.IsLeapYear(DateTime.Now.Year))         // и год високосный
                {
                    Console.WriteLine("февраль - високосный");
                }
                else
                {
                    Console.WriteLine("февраль - НЕ високосный");
                }
            }

            switch (DateTime.Now.Day)
            {
                case 30: Console.WriteLine("тридцатое"); break;
                
                case 31: Console.WriteLine("тридцатьпервое"); break;
            }
        }
    }
}