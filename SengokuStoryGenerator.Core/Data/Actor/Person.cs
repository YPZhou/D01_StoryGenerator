using BitButterCORE.V2;

namespace SengokuStoryGenerator.Core
{
	public class Person : BaseObject<Person>
	{
		public Person(uint id, IObjectReference<Clan> clan)
			: base(id)
		{
			Clan = clan;
			Name = NameGenerator.GetRandomPersonName(Clan);
		}

		IObjectReference<Clan> Clan { get; }

		public string Name { get; }
	}
}