namespace SengokuStoryGenerator.Core
{
	public class GivenNameNoumEntry : BasePoolEntry
	{
		public GivenNameNoumEntry(string noum, int weight)
			: base(weight)
		{
			GivenNameNoum = noum;
		}

		public string GivenNameNoum { get; }
	}
}
