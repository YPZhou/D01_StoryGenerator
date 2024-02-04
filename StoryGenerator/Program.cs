using BitButterCORE.V2;
using StoryGenerator.Core;
using static StoryGenerator.Core.Constants;

namespace StoryGenerator
{
	internal class Program
	{
		static void Main(string[] _)
		{
			var narrator = new Narrator(STORY_START_YEAR, STORY_START_MONTH);
			var story = new Story(narrator);

			ObjectFactory.Instance.Create<World>();

			GetPlotsAndTellStory(story.GetInitialPlots);
			for (var i = 0; i < 300 * MONTH_PER_YEAR ; i++)
			{
				GetPlotsAndTellStory(story.AdvanceTimeAndGetPlots);

				//var person = ObjectFactory.Instance.Create<Person>(clan);
				//Console.WriteLine($"角色{i + 1}：{person.Object.Name}");

				//if (i % 10 == 9)
				//{
				//	clan = ObjectFactory.Instance.Create<Clan>();
				//}
			}
		}

		static void GetPlotsAndTellStory(Func<IEnumerable<BasePlot>> plotsGetter)
		{
			var plots = plotsGetter.Invoke();
			foreach (var plot in plots)
			{
				plot.RevealPlot();
				Console.WriteLine(plot);
			}
		}
	}
}