using BitButterCORE.V2;
using static StoryGenerator.Core.Constants;

namespace StoryGenerator.Core
{
	static internal class NameGenerator
	{
		public static string GetRandomClanName()
		{
			var clanNameTypePool = new ClanNameTypePool();
			var clanNameAdjectivePool = new ClanNameAdjectivePool();
			var clanNameLocationPool = new ClanNameLocationPool();

			return string.Format(clanNameTypePool.DrawFromAllEntries().ClanNameType == ClanNameType.AdjectiveLocation ? "{0}{1}" : "{1}{0}",
				clanNameAdjectivePool.DrawFromAllEntries().ClanNameAdjective,
				clanNameLocationPool.DrawFromAllEntries().ClanNameLocation);
		}

		public static string GetRandomPersonName(IObjectReference<Clan> clan)
		{
			var clanName = clan.Object.Name;

			var givenNameTypePool = new GivenNameTypePool();
			var givenNameAdjectivePool = new GivenNameAdjectivePool();
			var givenNameNoumPool = new GivenNameNoumPool();

			var givenNameType = givenNameTypePool.DrawFromAllEntries().GivenNameType;
			var givenName = string.Format(givenNameType == GivenNameType.AdjectiveNoum ? "{0}{1}" : givenNameType == GivenNameType.NoumAdjective ? "{1}{0}" : "{0}{2}",
				givenNameAdjectivePool.DrawFromAllEntries().GivenNameAdjective,
				givenNameNoumPool.DrawFromAllEntries().GivenNameNoum,
				givenNameAdjectivePool.DrawFromAllEntries().GivenNameAdjective);

			return string.Concat(clanName, givenName);
		}
	}
}
