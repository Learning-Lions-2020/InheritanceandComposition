namespace IsA
{
	public class Dog : Animal
	{
		public Dog()
		{
			NoOfLegs = "4";
        }
		public override void Walk()
		{
			Console.WriteLine("Dog is walking");
		}
	}
}
