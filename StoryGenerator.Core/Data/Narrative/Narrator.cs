using BitButterCORE.V2;

namespace StoryGenerator.Core
{
	public class Narrator
	{
		public Narrator(int startYear, int startMonth, int startDay = 1)
		{
			StartYear = startYear;
			StartMonth = startMonth;
			StartDay = startDay;
		}

		public int StartYear { get; }

		public int StartMonth { get; }

		public int StartDay { get; }

		public IEnumerable<BasePlot> GetNextPlots(Calendar calendar)
		{
			var actors = ObjectFactory.Instance
				.Query<IBaseObject>()
				.Select(obj => obj.Object)
				.OfType<IActor>();

			foreach (var actor in actors)
			{
				var plot = actor.GetNextPlot(calendar.GetElapsedTime(StartYear, StartMonth, StartDay));
				if (plot != null)
				{
					yield return plot;
				}
			}
		}
	}
}
