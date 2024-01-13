namespace MvvmPractice
{
    class ConfigModel(int volume = 50)
    {
        public int Volume { get; set; } = volume;

        public void SaveConfig() => System.Diagnostics.Debug.WriteLine($"SaveConfig: Volume={Volume}");
    }
}
