using BitButterCORE.V2;

namespace StoryGenerator.Core
{
	public class Clan : BaseObject<Clan>, IActor
	{
		public Clan(uint id)
			: base(id)
		{
			Name = NameGenerator.GetRandomClanName();
		}

		public string Name { get; }

		public bool IsDestroyed => DestroyDate != null;

		public TimeSpan? DestroyDate { get; private set; }

		public IObjectReference<Person>? Leader => ObjectFactory.Instance.QueryFirst<Person>(person => person.Clan.Equals(Reference));

		BasePlot? IActor.GetNextPlot(TimeSpan currentTime, TimeSpan elapsedTime)
		{
			var result = default(BasePlot);
			if (!IsDestroyed)
			{
				var peopleInClan = ObjectFactory.Instance.Query<Person>(person => person.Clan.Equals(Reference) && !person.IsDead);
				if (!peopleInClan.Any())
				{
					result = new PlotClanDestroy(currentTime, Reference);
				}
			}

			return result;
		}

		public void DestroyClan(TimeSpan currentTime)
		{
			DestroyDate = new TimeSpan(currentTime.ElapsedYear, currentTime.ElapsedMonth, currentTime.ElapsedDay);
		}

		public override string ToString() => $"{Name}家";
	}
}
