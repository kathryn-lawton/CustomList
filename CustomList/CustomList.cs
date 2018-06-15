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
		private int count;
		private int capacity;

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

		public int Count { get; }
		
		public int Capacity
		{
			get { return capacity; }
			set { capacity = value; }
		}


		

		public void Add(T item)
		{

		}

		public void Remove(T item)
		{

		}

		public override string ToString()
		{
			return "";
		}

	}
}
