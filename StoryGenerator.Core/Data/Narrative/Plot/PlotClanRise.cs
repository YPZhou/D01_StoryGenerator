using BitButterCORE.V2;

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
			ObjectFactory.Instance.Create<Person>(clan, PlotTime);
		}

		IObjectReference<Clan>? clan;

		protected override string Description => string.Format("{0}崛起，家督{1}({2}岁)",
			clan?.Object.ToString() ?? string.Empty,
			clan?.Object.Leader?.Object.Name ?? string.Empty,
			new TimeSpan(clan?.Object.Leader?.Object.BirthDay ?? PlotTime, PlotTime).ElapsedYear + 1);
	}
}
