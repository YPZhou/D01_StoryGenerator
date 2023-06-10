﻿using static SengokuStoryGenerator.Core.Constants;

namespace SengokuStoryGenerator.Core
{
	static internal class PersonNameGenerator
	{
		public static string GetRandomPersonName()
		{
			var clanNameTypePool = new ClanNameTypePool();
			var clanNameAdjectivePool = new ClanNameAdjectivePool();
			var clanNameLocationPool = new ClanNameLocationPool();

			var clanName = string.Format(clanNameTypePool.DrawFromAllEntries().ClanNameType == ClanNameType.AdjectiveLocation ? "{0}{1}" : "{1}{0}",
				clanNameAdjectivePool.DrawFromAllEntries().ClanNameAdjective,
				clanNameLocationPool.DrawFromAllEntries().ClanNameLocation);

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
