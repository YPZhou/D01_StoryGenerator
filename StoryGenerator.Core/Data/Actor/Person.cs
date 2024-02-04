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

		public string Name { get; }

		BasePlot? IActor.GetNextPlot(TimeSpan currentTime, TimeSpan elapsedTime)
		{
			return null;
		}
	}
}