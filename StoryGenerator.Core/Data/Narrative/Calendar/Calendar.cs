namespace StoryGenerator.Core
{
	public class Calendar
	{
		public Calendar(TimeSpan currentTime)
		{
			this.currentTime = new TimeSpan(currentTime.ElapsedYear, currentTime.ElapsedMonth, currentTime.ElapsedDay);
		}

		TimeSpan currentTime;

		public void AdvanceTime(TimeSpan elapsedTime)
		{
			currentTime.AdvanceTime(elapsedTime);
		}

		public TimeSpan GetElapsedTime(TimeSpan startTime)
		{
			return new TimeSpan(startTime, currentTime);
		}

		public override string ToString() => $"{currentTime.ElapsedYear}年 {currentTime.ElapsedMonth}月 {currentTime.ElapsedDay}日";
	}
}
