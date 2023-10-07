namespace StoryGenerator.Core
{
	interface IActor
	{
		Plot? GetNextPlot(Calendar calendar);
	}
}
