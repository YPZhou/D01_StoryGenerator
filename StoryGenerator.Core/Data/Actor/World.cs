using BitButterCORE.V2;

namespace StoryGenerator.Core
{
	public class World : BaseObject<World>, IActor
	{
		public World(uint id)
			: base(id)
		{
		}

		BasePlot? IActor.GetNextPlot(TimeSpan elapsedTime)
		{
			var result = default(BasePlot);
			if (elapsedTime.TotalElapsedDay == 0)
			{
				result = new PlotClanRise();
			}

			return result;
		}
	}
}
