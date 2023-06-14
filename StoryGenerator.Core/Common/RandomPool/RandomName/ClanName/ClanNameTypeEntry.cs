using static StoryGenerator.Core.Constants;

namespace StoryGenerator.Core
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
