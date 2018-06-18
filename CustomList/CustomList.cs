using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
	public class CustomList<T>
	{
		public T[] items;
		public int Capacity { get { return itemCapacity; } set { itemCapacity = value; } }
		public int Count { get; private set; }
		public int itemCapacity;

		public CustomList()
		{
			itemCapacity = 4;
			Count = 0;
			this.items = new T[itemCapacity];
		}

		public T this[int i]
		{
			get
			{
				return items[i];
			}
			set
			{
				items[i] = value;
			}
		}

		public void Add(T item)
		{
			items[Count] = item;

			Count++;
			CheckCapacity();
		}

		public void CheckCapacity()
		{
			if (Count == itemCapacity)
			{
				itemCapacity *= 2;
				T[] newItems = new T[itemCapacity];
				for (int i = 0; i < Count; i++)
				{
					newItems[i] = items[i];
				}
				items = newItems;
			}
		}

		public bool Remove(T item)
		{
			T[] newItems = new T[itemCapacity];
			bool isFound = false;
			for (int i = 0; i < Count; i++)
			{
				if(items[i].Equals(item) && !isFound)
				{
					isFound = true;
					Count--;
				}
				else
				{
					int index = 0;
					if(isFound)
					{
						index = i - 1;
					}
					else
					{
						index = i;
					}

					newItems[index] = items[i];
				}
			}

			return isFound;
		}

		public override string ToString()
		{
			//for loop
			//StringBuilder
			return "";

		}

		public void Print()
		{
			foreach(T item in items)
			{
				Console.WriteLine(item);
			}
		}

	}
}
