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
			Order.ClearAll();
		}

		[TestMethod]
		public void OrderConstructor_CreatesInstanceOfOrder_Order()
		{
			Order newOrder = new Order("test", "test", 0, "test");
			Assert.AreEqual(typeof(Order), newOrder.GetType());
		}
	}
}
