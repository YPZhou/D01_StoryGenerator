namespace StoryGenerator.Core
{
	public class Calendar
	{
		public Calendar(TimeSpan currentTime)
		{
			CurrentTime = new TimeSpan(currentTime.ElapsedYear, currentTime.ElapsedMonth, currentTime.ElapsedDay);
		}

		public TimeSpan CurrentTime { get; }

		public void AdvanceTime(TimeSpan elapsedTime)
		{
			CurrentTime.AdvanceTime(elapsedTime);
		}

		public TimeSpan GetElapsedTime(TimeSpan startTime)
		{
			return new TimeSpan(startTime, CurrentTime);
		}
	}
}
