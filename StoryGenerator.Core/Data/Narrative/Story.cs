namespace StoryGenerator.Core
{
	public class Story
	{
		public Story(Narrator narrator)
		{
			this.narrator = narrator;
			calendar = new Calendar(narrator.StartYear, narrator.StartMonth);
		}

		readonly Narrator narrator;
		readonly Calendar calendar;

		public IEnumerable<Plot> AdvancePlots()
		{
			calendar.AdvanceTime(deltaMonth: 1);
			return narrator.GetNextPlots(calendar);
		}
	}
}
