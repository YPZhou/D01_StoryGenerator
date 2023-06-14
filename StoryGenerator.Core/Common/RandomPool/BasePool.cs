namespace StoryGenerator.Core
{
	public abstract class BasePool<T> where T : BasePoolEntry
	{
		public BasePool()
		{
			rand = new Random();
			InitializeConstantPool();
		}

		protected virtual void InitializeConstantPool() { }

		protected readonly Random rand;

		public T DrawFromAllEntries()
		{
			return WeightedRandomDraw(PoolEntries);
		}

		public T DrawFromValidEntries(Predicate<T> predicate)
		{
			var validEntries = PoolEntries.Where(entry => predicate(entry));
			return WeightedRandomDraw(validEntries);
		}

		protected T WeightedRandomDraw(IEnumerable<T> validEntries)
		{
			if (validEntries.Count() == 1)
			{
				return validEntries.Single();
			}
			else
			{
				var totalWeight = validEntries.Sum(entry => entry.Weight);
				var weightIndex = rand.Next(totalWeight);

				var currentWeightIndex = 0;
				foreach (var validEntry in validEntries)
				{
					currentWeightIndex += validEntry.Weight;
					if (currentWeightIndex > weightIndex)
					{
						return validEntry;
					}
				}
				return default;
			}
		}

		public void AddPoolEntry(T entry)
		{
			if (entry != null)
			{
				PoolEntries.Add(entry);
			}
		}

		protected List<T> PoolEntries => poolEntries ?? (poolEntries = new List<T>());
		List<T> poolEntries;
	}
}
