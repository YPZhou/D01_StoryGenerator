using BitButterCORE.V2;
using static StoryGenerator.Core.Constants;

namespace StoryGenerator.Core
{
	public class PlotClanRise : BasePlot
	{
		public PlotClanRise(TimeSpan currentTime)
			: base(currentTime)
		{
		}

		public override void RevealPlot()
		{
			clan = ObjectFactory.Instance.Create<Clan>();

			var rand = new Random();
			var leaderBirthDay = new TimeSpan(PlotTime.ElapsedYear - 15 - rand.Next(0, 30), rand.Next(1, MONTH_PER_YEAR + 1), rand.Next(1, DAY_PER_MONTH + 1));
			ObjectFactory.Instance.Create<Person>(clan, leaderBirthDay);
		}

		IObjectReference<Clan>? clan;

		protected override string Description => string.Format("{0}崛起，家督{1}({2}岁)",
			clan?.Object.ToString() ?? string.Empty,
			clan?.Object.Leader?.Object.Name ?? string.Empty,
			new TimeSpan(clan?.Object.Leader?.Object.BirthDay ?? PlotTime, PlotTime).ElapsedYear + 1);
	}
}
