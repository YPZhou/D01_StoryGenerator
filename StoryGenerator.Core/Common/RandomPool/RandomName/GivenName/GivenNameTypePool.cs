using static StoryGenerator.Core.Constants;

namespace StoryGenerator.Core
{
	public class GivenNameTypePool : BasePool<GivenNameTypeEntry>
	{
		protected override void InitializeConstantPool()
		{
			PoolEntries.Add(new GivenNameTypeEntry(GivenNameType.AdjectiveNoum, 5));
			PoolEntries.Add(new GivenNameTypeEntry(GivenNameType.NoumAdjective, 5));
			PoolEntries.Add(new GivenNameTypeEntry(GivenNameType.DoubleAdjective, 5));
		}
	}
}
