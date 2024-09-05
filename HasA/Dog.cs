namespace HasA
{
	public class Dog
	{
		private Tail Tail { get; set; }

		public Dog()
		{
			Tail = new Tail();
			Tail.Length = "3 meters";
			Tail.Color = "Brown";
		}

		public void DogProperties()
		{
			Console.WriteLine($"The dog has a tail of length {Tail.Length} and color {Tail.Color}");
			Tail.Wag();
		}
	}
}
