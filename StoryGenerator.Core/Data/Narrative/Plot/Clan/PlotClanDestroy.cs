using BitButterCORE.V2;

namespace StoryGenerator.Core
{
	public class PlotClanDestroy : BasePlot
	{
		public PlotClanDestroy(TimeSpan currentTime, IObjectReference<Clan> clan)
			: base(currentTime)
		{
			this.clan = clan;
		}

		IObjectReference<Clan>? clan;

		public override void RevealPlot()
		{
			clan?.Object.DestroyClan(PlotTime);
		}

		protected override string Description => $"{clan?.Object}灭亡。";
	}
}
