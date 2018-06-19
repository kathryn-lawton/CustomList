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
		public void Add_IncreaseCapacity_HigherCapacity()
		{
			CustomList<int> list = new CustomList<int>();
			int initialCapacity = list.Capacity;

			for(int i = 0; i < initialCapacity * 2; i++)
			{
				list.Add(i);
			}

			Assert.IsTrue(list.Capacity > initialCapacity);
		}

		public void Add_Object_ToEmptyList()
		{
			CustomList<Example> customList = new CustomList<Example>();
			Example testInput = new Example();

			customList.Add(testInput);

			Assert.AreEqual(customList[0], testInput);
		}

		[TestMethod]
		public void Add_MoreItemsThanCapacity_CheckCount()
		{
			CustomList<int> customList = new CustomList<int>();

			for(int i = 0; i < 5; i++)
			{
				customList.Add(i);
			}

			Assert.AreEqual(5, customList.Count);
		}

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

			customList.Add(1);
			customList.Add(expectedResult);
			customList.Remove(1);

			Assert.AreEqual(expectedResult, customList[0]);
		}

		[TestMethod]
		public void Check_RemoveOneItem_IsTrue()
		{
		
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

		//emptyList returns empty string
		//add elements, get length of tostring, add more elements, get length again, length should be greater than first

		//overload +
		[TestMethod]
		public void Add_TwoLists_NewList()
		{
			CustomList<int> custom = new CustomList<int>();
			CustomList<int> list1 = new CustomList<int>();
			CustomList<int> list2 = new CustomList<int>();
			CustomList<int> combinedList = new CustomList<int>();
			CustomList<int> expectedList = new CustomList<int>();

			for(int i = 0; i < 6; i++)
			{
				if(i <= 2)
				{
					list1.Add(i);
				}
				else
				{
					list2.Add(i);
				}
				expectedList.Add(i);
			}
			
			combinedList = list1 + list2;

			Assert.IsTrue(CustomList<int>.CompareLists(combinedList, expectedList));
		}
		//add empty list
		//add list of same items 
	}
}
