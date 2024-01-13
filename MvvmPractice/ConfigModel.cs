namespace MvvmPractice
{
    class ConfigModel(int volume = 50)
    {
        public int Volume { get; set; } = volume;
        public int Brightness { get; set; } = 128;

        public void SaveConfig()
        {
            System.Diagnostics.Debug.WriteLine($"SaveConfig: Volume={Volume}, Brightness={Brightness}");
        }
        // Rewrite SaveConfig() using lambda expression
        // public void SaveConfig() => System.Diagnostics.Debug.WriteLine($"SaveConfig: Volume={Volume}");
    }
}
