using static StoryGenerator.Core.Constants;

namespace StoryGenerator.Core
{
	public class TimeSpan
	{
		public static TimeSpan GetElapsedYears(int elapsedYear) => new TimeSpan(elapsedYear, 0, 0);

		public static TimeSpan GetElapsedMonths(int elapsedMonth) => new TimeSpan(0, elapsedMonth, 0);

		public static TimeSpan GetElapsedDays(int elapsedDay) => new TimeSpan(0, 0, elapsedDay);

		public TimeSpan(int elapsedYear, int elapsedMonth, int elapsedDay)
		{
			ElapsedYear = elapsedYear;
			ElapsedMonth = elapsedMonth;
			ElapsedDay = elapsedDay;
		}

		public TimeSpan(int totalElapsedDay)
		{
			ElapsedYear = totalElapsedDay / (MONTH_PER_YEAR * DAY_PER_MONTH);
			ElapsedMonth = (totalElapsedDay - ElapsedYear * MONTH_PER_YEAR * DAY_PER_MONTH) / DAY_PER_MONTH;
			ElapsedDay = totalElapsedDay - ElapsedMonth * DAY_PER_MONTH - ElapsedYear * MONTH_PER_YEAR * DAY_PER_MONTH;
		}

		public TimeSpan(TimeSpan fromTime, TimeSpan toTime)
			: this(toTime.TotalElapsedDay - fromTime.TotalElapsedDay)
		{
		}

		public int ElapsedYear { get; private set; }

		public int ElapsedMonth
		{
			get => elapsedMonth;
			private set
			{
				elapsedMonth = value;
				if (elapsedMonth > MONTH_PER_YEAR)
				{
					elapsedMonth %= MONTH_PER_YEAR;
					ElapsedYear += 1;
				}
			}
		}

		int elapsedMonth;

		public int ElapsedDay
		{
			get => elapsedDay;
			private set
			{
				elapsedDay = value;
				if (elapsedDay > DAY_PER_MONTH)
				{
					elapsedDay %= DAY_PER_MONTH;
					ElapsedMonth += 1;
				}
			}
		}

		int elapsedDay;

		public int TotalElapsedDay => ElapsedYear * MONTH_PER_YEAR * DAY_PER_MONTH + ElapsedMonth * DAY_PER_MONTH + ElapsedDay;

		public void AdvanceTime(TimeSpan elapsedTime)
		{
			ElapsedDay += elapsedTime.ElapsedDay;
			ElapsedMonth += elapsedTime.ElapsedMonth;
			ElapsedYear += elapsedTime.ElapsedYear;
		}

		public override string ToString() => $"{ElapsedYear}年 {ElapsedMonth}月 {ElapsedDay}日";
	}
}
