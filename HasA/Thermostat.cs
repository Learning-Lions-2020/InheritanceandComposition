namespace HasA
{
	public class Thermostat
	{
		public int Temperature { get; set; }

		public void SetTemperature(int temperature)
		{
			Temperature = temperature;
			Console.WriteLine($"Temperature set to {Temperature} degrees");
		}

		public void GetTemperature()
		{
			Console.WriteLine($"Temperature is {Temperature} degrees");
		}
	}
}
