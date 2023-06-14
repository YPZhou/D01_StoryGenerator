namespace SengokuStoryGenerator.Core
{
	public class ClanNameAdjectiveEntry : BasePoolEntry
	{
		public ClanNameAdjectiveEntry(string adjective, int weight)
			: base(weight)
		{
			ClanNameAdjective = adjective;
		}

		public string ClanNameAdjective { get; }
	}
}
