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
		int capacity;

		public CustomList()
		{
			capacity = 5;
			this.array = new T[capacity];
		}

		public void Add()
		{

		}

		public void Remove()
		{

		}

		public override string ToString()
		{
			return base.ToString();
		}
	}
}
