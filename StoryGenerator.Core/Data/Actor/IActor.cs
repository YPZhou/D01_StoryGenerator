namespace StoryGenerator.Core
{
	interface IActor
	{
		BasePlot? GetNextPlot(TimeSpan currentTime, TimeSpan elapsedTime);
	}
}
