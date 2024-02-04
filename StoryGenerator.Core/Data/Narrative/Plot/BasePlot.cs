namespace StoryGenerator.Core
{
	public abstract class BasePlot
	{
		public BasePlot(TimeSpan currentTime)
		{
			PlotTime = currentTime;
		}

		protected TimeSpan PlotTime { get; }

		public abstract void RevealPlot();

		public override string ToString() => $"{PlotTime} - {Description}";

		protected abstract string Description { get; }
	}
}
