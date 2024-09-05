namespace IsA
{
	public class Animal
	{
		public virtual string NoOfLegs { get; set; } = string.Empty;
		public virtual string? NoOfWings { get; set; }

		public virtual void Walk()
		{
			Console.WriteLine("Walking");
		}	
	}
}
