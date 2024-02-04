using BitButterCORE.V2;

namespace StoryGenerator.Core
{
	public class Person : BaseObject<Person>, IActor
	{
		public Person(uint id, IObjectReference<Clan> clan, TimeSpan birthDay)
			: base(id)
		{
			Clan = clan;
			Name = NameGenerator.GetRandomPersonName(Clan);

			BirthDay = birthDay;
		}

		public IObjectReference<Clan> Clan { get; }

		public TimeSpan BirthDay { get; }

		public int GetAge(TimeSpan currentTime) => new TimeSpan(BirthDay, currentTime).ElapsedYear + 1;

		public string Name { get; }

		public bool IsDead => DeathDay != null;

		public TimeSpan? DeathDay { get; private set; }

		BasePlot? IActor.GetNextPlot(TimeSpan currentTime, TimeSpan elapsedTime)
		{
			var rand = new Random();
			var result = default(BasePlot);
			if (!IsDead)
			{
				var age = GetAge(currentTime);
				if (age >= 40)
				{
					if (rand.Next(20000) < age)
					{
						result = new PlotPersonDeathByIllness(currentTime, Reference);
					}
				}
			}

			return result;
		}

		public void DieByIllness(TimeSpan currentTime)
		{
			DeathDay = new TimeSpan(currentTime.ElapsedYear, currentTime.ElapsedMonth, currentTime.ElapsedDay);
		}
	}
}