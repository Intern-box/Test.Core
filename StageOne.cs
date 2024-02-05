using StageTwoSpace;
using Test.Core;

namespace StageOneSpace
{
    public class StageOne // Presenter
    {
        public StageOne()
        {
            Console.WriteLine($"StageOne: Презентёр инициирует запуск следующей формы\n");

            Console.WriteLine($"и передаёт результат из неё в Базовую форму.\n");

            StageTwo stageTwo = new();

            Program.str = stageTwo.StringFromStageTwo;
        }
    }
}