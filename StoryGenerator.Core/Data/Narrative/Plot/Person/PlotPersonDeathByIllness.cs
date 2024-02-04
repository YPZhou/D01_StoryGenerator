using BitButterCORE.V2;

namespace StoryGenerator.Core
{
	public class PlotPersonDeathByIllness : BasePlot
	{
		public PlotPersonDeathByIllness(TimeSpan currentTime, IObjectReference<Person> person)
			: base(currentTime)
		{
			this.person = person;
		}

		IObjectReference<Person>? person;

		public override void RevealPlot()
		{
			person?.Object.DieByIllness(PlotTime);
		}

		protected override string Description => $"{person?.Object.Name}({person?.Object.GetAge(PlotTime)}岁)病死。";
	}
}
