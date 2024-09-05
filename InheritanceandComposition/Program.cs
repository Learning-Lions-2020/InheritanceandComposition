using HasA;

/*Student student = new Student("Loropio", "Olsen", 25);
student.DisplayInfo();

Teacher teacher = new Teacher("C#", "Jerry", 35);
teacher.DisplayInfo();

Teacher youngTeacher = new Teacher("C++", "Boni", 12);
youngTeacher.DisplayInfo();*/

var bulbs = new Bulb[]
{
	new Bulb { Location = "Kitchen" },
	new Bulb { Location = "Living Room" },
	new Bulb { Location = "Bedroom" }
};

var thermostat = new Thermostat() { Temperature = 25};
var myHouse = new House(bulbs, thermostat);
myHouse.EnterHouse();