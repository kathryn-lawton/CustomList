using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
	public class CustomList<T> : IEnumerable<T>
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

			if(isFound)
			{
				Count--;
			}

			items = newItems;

			return isFound;
		}

		public override string ToString()
		{
			string returnString = string.Empty;
			for (int i = 0; i < Count; i ++)
			{
				if (i == Count - 1)
				{
					returnString += items[i].ToString();
				}
				else
				{
					returnString += items[i].ToString() + ", ";
				}
			}
			return returnString;
		}

		public void Print()
		{
			foreach(T item in items)
			{
				Console.WriteLine(item);
			}
		}

		public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2)
		{
			CustomList<T> newItems = new CustomList<T>();
			for(int i = 0; i < list1.Count; i++)
			{
				newItems.Add(list1[i]);
			}

			for (int i = 0; i < list2.Count; i++)
			{
				newItems.Add(list2[i]);
			}

			return newItems;
		}


		public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2)
		{
			CustomList<T> newItems = new CustomList<T>();
			for (int i = 0; i < list1.Count; i++)
			{
				newItems.Add(list1[i]);
			}

			for (int i = 0; i < list2.Count; i++)
			{
				newItems.Remove(list2[i]);
			}

			return newItems;
		}

		public static CustomList<T> ZipLists(CustomList<T> list1, CustomList<T> list2)
		{
			CustomList<T> zippedList = new CustomList<T>();
			int largerCount = 0;
			if (list1.Count > list2.Count)
			{
				largerCount = list1.Count;
			}
			else
			{
				largerCount = list2.Count;
			}

			for (int i = 0; i < largerCount; i++)
			{
				if (i < list1.Count)
				{
					zippedList.Add(list1[i]);
				}

				if (i < list2.Count)
				{
					zippedList.Add(list2[i]);
				}
			}

			return zippedList;
		}

		public static bool CompareLists(CustomList<T> items1, CustomList<T> items2)
		{
			if (items1.Count != items2.Count)
			{
				return false;
			}

			for (int i = 0; i < items1.Count; i++)
			{
				if (!items1[i].Equals(items2[i]))
				{
					return false;
				}
			}

			return true;
		}

		public IEnumerator<T> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}


	}
}
