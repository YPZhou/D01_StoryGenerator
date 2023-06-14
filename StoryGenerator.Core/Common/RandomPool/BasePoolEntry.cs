namespace StoryGenerator.Core
{
	public abstract class BasePoolEntry
	{
		public BasePoolEntry(int weight)
		{
			Weight = weight;
		}

		public int Weight
		{
			get => weight;
			set
			{
				if (value > 0)
				{
					weight = value;
				}
			}
		}
		int weight;
	}
}
