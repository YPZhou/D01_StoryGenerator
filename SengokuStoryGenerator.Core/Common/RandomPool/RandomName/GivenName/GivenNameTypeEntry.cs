using static SengokuStoryGenerator.Core.Constants;

namespace SengokuStoryGenerator.Core
{
	public class GivenNameTypeEntry : BasePoolEntry
	{
		public GivenNameTypeEntry(GivenNameType type, int weight)
			: base(weight)
		{
			GivenNameType = type;
		}

		public GivenNameType GivenNameType { get; }
	}
}
