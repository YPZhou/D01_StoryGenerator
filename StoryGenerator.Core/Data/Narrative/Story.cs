namespace StoryGenerator.Core
{
	public class Story
	{
		public Story(Narrator narrator)
		{
			this.narrator = narrator;
			calendar = new Calendar(narrator.StartTime);
		}

		readonly Narrator narrator;
		readonly Calendar calendar;

		public IEnumerable<BasePlot> GetInitialPlots()
		{
			return narrator.GetNextPlots(calendar);
		}

		public IEnumerable<BasePlot> AdvanceTimeAndGetPlots()
		{
			calendar.AdvanceTime(TimeSpan.GetElapsedMonths(1));
			return narrator.GetNextPlots(calendar);
		}
	}
}
