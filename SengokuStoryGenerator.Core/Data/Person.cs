using BitButterCORE.V2;
using SengokuStoryGenerator.Core;

namespace SengokuStoryGenerator
{
	public class Person : BaseObject<Person>
	{
		public Person(uint id)
			: base(id)
		{
			Name = PersonNameGenerator.GetRandomPersonName();
		}

		public string Name { get; }
	}
}