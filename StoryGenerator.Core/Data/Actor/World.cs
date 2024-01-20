using BitButterCORE.V2;

namespace StoryGenerator.Core
{
	public class World : BaseObject<World>, IActor
	{
		public World(uint id)
			: base(id)
		{
		}

		Plot? IActor.GetNextPlot(TimeSpan timeSpan)
		{
			return null;
		}
	}
}
