using BitButterCORE.V2;

namespace StoryGenerator.Core
{
	public class PlotChildBirth : BasePlot
	{
		public PlotChildBirth(TimeSpan currentTime, IObjectReference<Person> parent)
			: base(currentTime)
		{
			this.parent = parent;
		}

		IObjectReference<Person>? parent;
		IObjectReference<Person>? child;

		public override void RevealPlot()
		{
			child = ObjectFactory.Instance.Create<Person>(parent?.Object.Clan, PlotTime);
		}

		protected override string Description => $"{parent?.Object.Name}之子{child?.Object.Name}诞生。";
	}
}
