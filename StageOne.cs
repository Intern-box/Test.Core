using StageTwoSpace;
using Test.Core;

namespace StageOneSpace
{
    public class StageOne // Presenter
    {
        public StageOne()
        {
            StageTwo stageTwo = new();

            Program.str = stageTwo.StringFromStageTwo;
        }
    }
}