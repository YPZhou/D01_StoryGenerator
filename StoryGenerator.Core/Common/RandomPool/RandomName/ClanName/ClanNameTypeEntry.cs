using static SengokuStoryGenerator.Core.Constants;

namespace SengokuStoryGenerator.Core
{
	public class ClanNameTypeEntry : BasePoolEntry
	{
		public ClanNameTypeEntry(ClanNameType type, int weight)
			: base(weight)
		{
			ClanNameType = type;
		}

		public ClanNameType ClanNameType { get; }
	}
}
