using BitButterCORE.V2;
using SengokuStoryGenerator.Core;

namespace SengokuStoryGenerator
{
	internal class Program
	{
		static void Main(string[] _)
		{
			var clan = ObjectFactory.Instance.Create<Clan>();
			for (var i = 0; i < 50; i++)
			{
				var person = ObjectFactory.Instance.Create<Person>(clan);
				Console.WriteLine($"角色{i + 1}：{person.Object.Name}");

				if (i % 10 == 9)
				{
					clan = ObjectFactory.Instance.Create<Clan>();
				}
			}
		}
	}
}