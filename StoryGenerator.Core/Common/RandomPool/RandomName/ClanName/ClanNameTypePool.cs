using static SengokuStoryGenerator.Core.Constants;

namespace SengokuStoryGenerator.Core
{
	public class ClanNameTypePool : BasePool<ClanNameTypeEntry>
	{
		protected override void InitializeConstantPool()
		{
			PoolEntries.Add(new ClanNameTypeEntry(ClanNameType.AdjectiveLocation, 5));
			PoolEntries.Add(new ClanNameTypeEntry(ClanNameType.LocationAdjective, 5));
		}
	}
}
