using static StoryGenerator.Core.Constants;

namespace StoryGenerator.Core
{
	public class Calendar
	{
		public Calendar(int year, int month, int day = 1)
		{
			Year = year;
			this.month = month;
			this.day = day;
		}

		public int Year { get; private set; }

		public int Month
		{
			get => month;

			private set
			{
				month = value;
				if (month > MONTH_PER_YEAR)
				{
					month %= MONTH_PER_YEAR;
					Year += 1;
				}
			}
		}

		int month;

		public int Day
		{
			get => day;

			private set
			{
				day = value;
				if (day > DAY_PER_MONTH)
				{
					day %= DAY_PER_MONTH;
					month += 1;
				}
			}
		}

		int day;

		public void AdvanceTime(int deltaDay = 1, int deltaMonth = 0, int deltaYear = 0)
		{
			Day += deltaDay;
			Month += deltaMonth;
			Year += deltaYear;
		}
	}
}
