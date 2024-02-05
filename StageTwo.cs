using StageThreeSpace;

namespace StageTwoSpace
{
    public class StageTwo // AddEditSearchView
    {
        public string StringFromStageTwo = string.Empty;

        public StageTwo()
        {
            Console.WriteLine($"StageTwo: Вторая форма передаёт данные своему Презентёру.\n");

            StringFromStageTwo = "Hi, User!";

            StageThree stageThree = new(StringFromStageTwo);
        }
    }
}