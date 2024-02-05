namespace StageFourSpace
{
    public class StageFour // AddEditSearchModel
    {
        public string StringFromStageFour = string.Empty;

        public StageFour(string Str)
        {
            Console.WriteLine($"StageFour: Модель получает и сохраняет данные.\n");

            StringFromStageFour = Str;
        }
    }
}