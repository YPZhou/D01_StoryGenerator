using BitButterCORE.V2;

namespace StoryGenerator.Core
{
	public class PlotCreateClan : BasePlot
	{
		public override void RevealPlot()
		{
			clan = ObjectFactory.Instance.Create<Clan>();
			ObjectFactory.Instance.Create<Person>(clan);
		}

		IObjectReference<Clan>? clan;

		protected override string Description => $"{clan?.Object.Name ?? string.Empty}家 {clan?.Object.Leader?.Object.Name ?? string.Empty} 诞生。";
	}
}
