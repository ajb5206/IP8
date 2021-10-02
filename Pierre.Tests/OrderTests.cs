using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreTracker.Models;
using System.Collections.Generic;
using System;

namespace PierreTracker.Tests
{
	[TestClass]
	public class OrderTests : IDisposable
	{
		public void Dispose()
		{
			Item.ClearAll();
		}

		[TestMethod]
		public void OrderConstructor_CreatesInstanceOfOrder_Order()
		{
			Order newOrder = new Order("test", 0);
			Assert.AreEqual(typeof(Order), newOrder.GetType());
		}
	}
}
