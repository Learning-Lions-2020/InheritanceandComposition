namespace HasA
{
	public class Tail
	{
		public string Length { get; set; } = string.Empty;
		public string Color { get; set; } = string.Empty;

		public void Wag()
		{
			Console.WriteLine("Tail is wagging");
		}
	}
}
