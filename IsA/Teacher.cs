namespace IsA
{
	public class Teacher : Person
	{
		public string? Subject { get; private set; }

        public Teacher()
        {
            
        }

        public Teacher(string subject, string name, int age) : base(name, age)
        {
			Subject = subject;

			if (age < 18)
			{
                Console.WriteLine("You are not allowed to teach! Too young!");
            }
        }

        public override void DisplayInfo()
		{
			base.DisplayInfo();
			Console.WriteLine($"Subject: {Subject}");
		}
	}
}