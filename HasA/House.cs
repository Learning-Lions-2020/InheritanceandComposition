namespace HasA
{
	public class House
	{
		public Bulb[] Bulbs { get; set; }
		public Thermostat Thermostat { get; set; }

        public House(Bulb[] bulbs, Thermostat thermostat)
        {
            Bulbs = bulbs;
            Thermostat = thermostat;
        }

        public void EnterHouse()
        {
            foreach (var bulb in Bulbs)
            {
				bulb.TurnOn();
			}
            Thermostat.GetTemperature();
        }
    }
}
