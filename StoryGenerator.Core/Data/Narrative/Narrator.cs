using BitButterCORE.V2;

namespace StoryGenerator.Core
{
	public class Narrator
	{
		public Narrator(int startYear, int startMonth, int startDay = 1)
		{
			StartTime = new TimeSpan(startYear, startMonth, startDay);
		}

		public TimeSpan StartTime { get; }

		public IEnumerable<BasePlot> GetNextPlots(Calendar calendar)
		{
			var actors = ObjectFactory.Instance
				.Query<IBaseObject>()
				.Select(obj => obj.Object)
				.OfType<IActor>();

			foreach (var actor in actors)
			{
				var plot = actor.GetNextPlot(calendar.CurrentTime, calendar.GetElapsedTime(StartTime));
				if (plot != null)
				{
					yield return plot;
				}
			}
		}
	}
}
