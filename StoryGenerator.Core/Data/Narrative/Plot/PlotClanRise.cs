using BitButterCORE.V2;

namespace StoryGenerator.Core
{
	public class PlotClanRise : BasePlot
	{
		public override void RevealPlot()
		{
			clan = ObjectFactory.Instance.Create<Clan>();
			ObjectFactory.Instance.Create<Person>(clan);
		}

		IObjectReference<Clan>? clan;

		protected override string Description => $"{clan?.Object.ToString() ?? string.Empty} 崛起，家督 {clan?.Object.Leader?.Object.Name ?? string.Empty}。";
	}
}
