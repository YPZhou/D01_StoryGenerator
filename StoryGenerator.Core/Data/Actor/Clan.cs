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

		Plot? IActor.GetNextPlot(Calendar calendar)
		{
			return null;
		}
	}
}
