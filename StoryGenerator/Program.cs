using BitButterCORE.V2;
using StoryGenerator.Core;

namespace StoryGenerator
{
	internal class Program
	{
		static void Main(string[] _)
		{
			var narrator = new Narrator(1540, 1);
			var story = new Story(narrator);

			ObjectFactory.Instance.Create<World>();

			GetPlotsAndTellStory(story.GetInitialPlots, story.GetCalendarTime);
			for (var i = 0; i < 50; i++)
			{
				GetPlotsAndTellStory(story.AdvanceTimeAndGetPlots, story.GetCalendarTime);

				//var person = ObjectFactory.Instance.Create<Person>(clan);
				//Console.WriteLine($"角色{i + 1}：{person.Object.Name}");

				//if (i % 10 == 9)
				//{
				//	clan = ObjectFactory.Instance.Create<Clan>();
				//}
			}
		}

		static void GetPlotsAndTellStory(Func<IEnumerable<BasePlot>> plotsGetter, Func<string> calendarTimeGetter)
		{
			var calendarTime = calendarTimeGetter.Invoke();
			var plots = plotsGetter.Invoke();
			foreach (var plot in plots)
			{
				plot.RevealPlot();
				Console.WriteLine($"{calendarTime} - {plot}");
			}
		}
	}
}