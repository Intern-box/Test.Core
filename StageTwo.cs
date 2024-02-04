using StageThreeSpace;

namespace StageTwoSpace
{
    public class StageTwo // AddEditSearchView
    {
        public string StringFromStageTwo = string.Empty;

        public StageTwo()
        {
            StringFromStageTwo = "Hi, User!";

            StageThree stageThree = new(StringFromStageTwo);
        }
    }
}