namespace StoryGenerator.Core
{
	public class ClanNameLocationEntry : BasePoolEntry
	{
		public ClanNameLocationEntry(string location, int weight)
			: base(weight)
		{
			ClanNameLocation = location;
		}

		public string ClanNameLocation { get; }
	}
}
