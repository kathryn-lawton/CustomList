using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
	public class CustomList<T>
	{
		T[] array;
		public int Count { get; }
		int capacity;
		StringBuilder convertedString;

		public CustomList()
		{
			capacity = 5;
			this.array = new T[capacity];
		}

		public T this[int i]
		{
			get
			{
				return array[i];
			}
			set
			{
				array[i] = value;
			}
		}
	
		public int Capacity
		{
			get { return capacity; }
			set { capacity = value; }
		}


		public void Add(T item)
		{
			T[] temporaryArray = new T[array.Length + 1];
			for (int i = 0; i < array.Length; i++)
			{
				temporaryArray[i] = array[i];
			}
			temporaryArray[array.Length] = item;
			array = temporaryArray;
		}

		public void Remove(T item)
		{

		}

		public override string ToString()
		{
			return "";

		}

		public void Print()
		{
			foreach(T item in array)
			{
				Console.WriteLine(item);
			}
		}

	}
}
