using StageOneSpace;

namespace Test.Core
{
    public class Program // BaseView
    {
        static public string str = string.Empty;

        public static void Main()
        {
            Console.Clear();

            Console.WriteLine($"\nProgram: Запуск Базовой формы и ожидание запроса пользователя.\n");

            StageOne stageOne = new();

            Console.WriteLine($"Данные: {str}\n");
        }
    }
}