namespace IsA
{
	public class Student : Person
	{
		public string School { get; private set; }

        public Student(string school, string name, int age) : base(name, age)
		{
			School = school;
		}

        public override void DisplayInfo()
		{
			base.DisplayInfo();
			Console.WriteLine($"School: {School}");
		}
	}
}