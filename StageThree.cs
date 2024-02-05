using StageTwoSpace;
using StageFourSpace;

namespace StageThreeSpace
{
    public class StageThree // AddEditSearchPresenter
    {
        public StageThree(string Str)
        {
            Console.WriteLine($"StageThree: Презентёр второй формы получает данные\n");

            Console.WriteLine($"и инициирует объект Модели, передаёт данные ей.\n");

            StageFour stageFour = new(Str);
        }
    }
}