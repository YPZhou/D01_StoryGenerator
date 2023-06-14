namespace StoryGenerator.Core
{
	public class GivenNameAdjectiveEntry : BasePoolEntry
	{
		public GivenNameAdjectiveEntry(string adjective, int weight)
			: base(weight)
		{
			GivenNameAdjective = adjective;
		}

		public string GivenNameAdjective { get; }
	}
}
