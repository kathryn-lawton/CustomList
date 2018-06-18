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
		public int Count { get; }
		public int itemCapacity;
		public int currentCount;


		public CustomList()
		{
			itemCapacity = 4;
			currentCount = 0;
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
			for(int i = 0; i <= currentCount; i++)
			{
				if (currentCount == i)
				{
					items[i] = item;
				}
			}
			currentCount++;
			CheckCapacity();
		}

		public void CheckCapacity()
		{
			if (currentCount == itemCapacity)
			{
				itemCapacity *= 2;
				T[] newItems = new T[itemCapacity];
				for (int i = 0; i < currentCount; i++)
				{
					items[i] = newItems[i];
				}
				newItems = items;
			}
			//check if at capacity
			//if at capacity, create new array with *=2 capacity
			//copy items into new array w/ loop
		}

		public bool Remove(T item)
		{
			return true;
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
