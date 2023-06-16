using static StoryGenerator.Core.Constants;

namespace StoryGenerator.Core
{
	internal class Calendar
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
				month += 1;
				if (month > MONTH_PER_YEAR)
				{
					month = 1;
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
				day += 1;
				if (day > DAY_PER_MONTH)
				{
					day = 1;
					Month += 1;
				}
			}
		}

		int day;
	}
}
