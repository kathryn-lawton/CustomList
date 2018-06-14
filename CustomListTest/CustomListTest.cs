using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
	[TestClass]
	public class CustomListTest
	{
		[TestMethod]
		public void Add_FirstValue_ZeroIndex()
		{
			List<int> customList = new List<int>();
			int firstValue = 1;

			customList.Add(firstValue);

			Assert.AreEqual(firstValue, customList[0]);
		}

		[TestMethod]
		public void Add_SecondValue_FirstIndex()
		{
			List<int> customList = new List<int>();
			int secondValue = 2;

			customList.Add(secondValue);

			Assert.AreEqual(secondValue, customList[1]);
		}
	}
}
