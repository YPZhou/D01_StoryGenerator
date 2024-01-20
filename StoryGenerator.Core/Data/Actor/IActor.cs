namespace StoryGenerator.Core
{
	interface IActor
	{
		Plot? GetNextPlot(TimeSpan timeSpan);
	}
}
