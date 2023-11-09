namespace Test.Core
{
    public class Program
    {
        public string SayHi = "Привет!";

        public static void Main()
        {
            Console.WriteLine("пробую создать объект с ссылкой на родителя:\n\n");

            Test test = new Test(this);
        }
    }
}