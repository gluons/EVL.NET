using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static EVLLibrary.EVLFunc;

namespace EVLTest
{
	[TestClass]
	public class EVLUnitTest
	{
		[TestMethod]
		public void TestEVLFallbackFuncReturnMain()
		{
			Func<int> mainFunc = () =>
			{
				return 1;
			};
			Func<int> fallbackFunc = () =>
			{
				return 2;
			};

			Assert.AreEqual(EVL(mainFunc, fallbackFunc), 1);
		}

		[TestMethod]
		public void TestEVLFallbackFuncReturnFallback()
		{
			Func<int> mainFunc = () =>
			{
				throw new Exception("Error");
			};
			Func<int> fallbackFunc = () =>
			{
				return 2;
			};

			Assert.AreEqual(EVL(mainFunc, fallbackFunc), 2);
		}

		[TestMethod]
		public void TestEVLValueReturnMain()
		{
			Func<int> mainFunc = () =>
			{
				return 1;
			};
			var fallbackValue = 2;

			Assert.AreEqual(EVL(mainFunc, fallbackValue), 1);
		}

		[TestMethod]
		public void TestEVLValueReturnFallback()
		{
			Func<int> mainFunc = () =>
			{
				throw new Exception("Error");
			};
			var fallbackValue = 2;

			Assert.AreEqual(EVL(mainFunc, fallbackValue), 2);
		}
	}
}
