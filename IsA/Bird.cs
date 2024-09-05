namespace IsA
{
	public class Bird : Animal
	{
		public Bird()
		{
			NoOfLegs = "2";
			NoOfWings = "2";
		}
		public override void Walk()
		{
			Console.WriteLine("Bird is flying");
		}
	}
}
