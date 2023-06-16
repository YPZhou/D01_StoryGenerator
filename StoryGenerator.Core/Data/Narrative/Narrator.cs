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
	}
}
