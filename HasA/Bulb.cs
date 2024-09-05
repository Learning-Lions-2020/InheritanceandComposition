namespace HasA
{
	public class Bulb
	{
		public string Location { get; set; }

		public void TurnOn()
		{
            Console.WriteLine($"Bulb in {Location} is on");
		}

		public void TurnOff()
		{
			Console.WriteLine($"Bulb in {Location} is off");
		}
	}
}
