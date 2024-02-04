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
			return GetPlotsForActors<Person>(calendar)
				.Concat(GetPlotsForActors<Clan>(calendar))
				.Concat(GetPlotsForActors<World>(calendar));
		}

		IEnumerable<BasePlot> GetPlotsForActors<ActorType>(Calendar calendar) where ActorType : IActor, IBaseObject
		{
			var actors = ObjectFactory.Instance.Query<ActorType>().Select(reference => reference.Object);
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
