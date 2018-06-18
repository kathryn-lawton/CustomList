using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;
using System.Collections.Generic;



namespace CustomListTest
{
	[TestClass]
	public class CustomListTest
	{
		//Add
		[TestMethod]
		public void Add_FirstValue_ZeroIndex()
		{
			CustomList<int> customList = new CustomList<int>();
			int firstValue = 1;

			customList.Add(firstValue);

			Assert.AreEqual(firstValue, customList[0]);
		}

		[TestMethod]
		public void Add_SecondValue_FirstIndex()
		{
			CustomList<int> customList = new CustomList<int>();
			int firstValue = 1;
			int secondValue = 2;

			customList.Add(firstValue);
			customList.Add(secondValue);


			Assert.AreEqual(secondValue, customList[1]);
		}

		[TestMethod]
		public void Add_GetList_Count()
		{
			CustomList<int> customList = new CustomList<int>();
			int expectedCount = 3;

			customList.Add(0);
			customList.Add(1);
			customList.Add(2);
			int actualResult = customList.Count;

			Assert.AreEqual(expectedCount, actualResult);
		}

		[TestMethod]
		public void Check_Capacity()
		{
			CustomList<Array> customList = new CustomList<Array>();
			int[] inputValue = new int[] { };

			customList.Add(inputValue);

			Assert.AreEqual(customList[0], inputValue);
		}

		public void Add_Object_ToEmptyList()
		{
			CustomList<Array> customList = new CustomList<Array>();
			Example testInput = new Example();

			customList.Add(testInput);

			Assert.AreEqual(customList[0], testInput);
		}

		public void Add_NewList_ToCustomList()
		{
			List<int> newList = new List<int>();
			CustomList<List<int>> customList = new CustomList<List<int>>();

			customList.Add(newList);

			Assert.AreEqual(customList[0], newList);
		}

		//Array - if 5 index and you want 6, redeclare and check size

		//Remove
		[TestMethod]
		public void Check_ValueAt_FirstIndex()
		{
			CustomList<int> customList = new CustomList<int>();
			int numberValue = 4;

			customList.Add(5);
			customList.Add(3);
			customList.Add(numberValue);
			customList.Remove(3);

			Assert.AreEqual(numberValue, customList[1]);
		}

		[TestMethod]
		public void Check_ValueAt_SecondIndex()
		{
			CustomList<int> customList = new CustomList<int>();
			int numberValue = 4;

			customList.Add(5);
			customList.Add(3);
			customList.Add(1);
			customList.Add(numberValue);
			customList.Remove(3);

			Assert.AreEqual(numberValue, customList[2]);
		}

		[TestMethod]
		public void Remove_FirstValue_ReturnSecondValue()
		{
			CustomList<int> customList = new CustomList<int>();
			int firstValue = 1;
			int secondValue = 2;

			customList.Add(firstValue);
			customList.Add(secondValue);
			customList.Add(2);
			customList.Remove(firstValue);

			Assert.AreEqual(secondValue, customList[0]);
		}

		[TestMethod]
		public void Remove_GetList_Count()
		{
			CustomList<int> customList = new CustomList<int>();
			int expectedCount = 2;

			customList.Add(0);
			customList.Add(1);
			customList.Add(2);
			customList.Remove(1);

			int actualResult = customList.Count;
			Assert.AreEqual(expectedCount, actualResult);
		}

		[TestMethod]
		public void Check_Index_IntValue()
		{
			CustomList<int> customList = new CustomList<int>();
			int expectedResult = 0;

			customList.Add(0);
			customList.Add(1);
			customList.Remove(1);

			Assert.AreEqual(expectedResult, customList[1]);
		}

		//count
		//exception array size 5, looking for 7th index


		//tostring
		//OVERRIDE DON'T OVERLOAD

		[TestMethod]
		public void Check_Value_IsString()
		{
			CustomList<int> customList = new CustomList<int>();
			string expectedResult = "3";

			customList.Add(3);
			string actualResult = customList.ToString();

			Assert.AreEqual(expectedResult, actualResult);
		}

		[TestMethod]
		public void Check_SecondValue_IsString()
		{
			CustomList<int> customList = new CustomList<int>();
			string expectedResult = "2";

			customList.Add(1);
			customList.Add(2);
			string actualResult = customList.ToString();

			Assert.AreEqual(expectedResult, actualResult);
		}

		
	}
}
