using BitButterCORE.V2;

namespace StoryGenerator.Core
{
	public class Clan : BaseObject<Clan>, IActor
	{
		public Clan(uint id)
			: base(id)
		{
			Name = NameGenerator.GetRandomClanName();
		}

		public string Name { get; }

		public IObjectReference<Person>? Leader => ObjectFactory.Instance.QueryFirst<Person>(person => person.Clan.Equals(Reference));

		BasePlot? IActor.GetNextPlot(TimeSpan timeSpan)
		{
			return null;
		}
	}
}
