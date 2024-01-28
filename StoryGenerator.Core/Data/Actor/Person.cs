using BitButterCORE.V2;

namespace StoryGenerator.Core
{
	public class Person : BaseObject<Person>, IActor
	{
		public Person(uint id, IObjectReference<Clan> clan)
			: base(id)
		{
			Clan = clan;
			Name = NameGenerator.GetRandomPersonName(Clan);
		}

		public IObjectReference<Clan> Clan { get; }

		public string Name { get; }

		BasePlot? IActor.GetNextPlot(TimeSpan timeSpan)
		{
			return null;
		}
	}
}