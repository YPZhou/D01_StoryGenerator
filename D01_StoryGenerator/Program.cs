using BitButterCORE.V2;

namespace SengokuStoryGenerator
{
	internal class Program
	{
		static void Main(string[] _)
		{
			for (var i = 0; i < 50; i++)
			{
				var person = ObjectFactory.Instance.Create<Person>();
				Console.WriteLine($"角色{i + 1}：{person.Object.Name}");
			}
		}
	}
}