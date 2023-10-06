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

			var clan = ObjectFactory.Instance.Create<Clan>();
			ObjectFactory.Instance.Create<Person>(clan);

			for (var i = 0; i < 50; i++)
			{
				var plot = story.AdvancePlot();
				if (plot != null)
				{
					Console.WriteLine(plot);
				}

				//var person = ObjectFactory.Instance.Create<Person>(clan);
				//Console.WriteLine($"角色{i + 1}：{person.Object.Name}");

				//if (i % 10 == 9)
				//{
				//	clan = ObjectFactory.Instance.Create<Clan>();
				//}
			}
		}
	}
}