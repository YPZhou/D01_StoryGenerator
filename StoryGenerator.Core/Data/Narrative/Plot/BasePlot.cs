namespace StoryGenerator.Core
{
	public abstract class BasePlot
	{
		public abstract void RevealPlot();

		public override string ToString() => Description;

		protected abstract string Description { get; }
	}
}
