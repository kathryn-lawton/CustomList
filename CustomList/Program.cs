using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
	class Program
	{
		static void Main(string[] args)
		{
			CustomList <int> customList = new CustomList <int>();

			customList.Add(1);
			customList.Add(2);
			customList.Add(3);
			customList.Add(4);
			customList.Add(5);
			customList.Remove(1);

			foreach (int item in customList)
			{
				Console.WriteLine(item);
			}
			Console.ReadLine();

			
		}
	}
}
