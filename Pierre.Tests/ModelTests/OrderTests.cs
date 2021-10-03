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

		[TestMethod]
		public void GetProduct_ReturnsProduct_String()
		{
			string product = "bread";
			string productDescription ="The bread is tasty here.";
			int price = 1;
			string date = "today";
			Order newOrder = new Order(product, productDescription, price, date);
			string result = newOrder.Product;
			Assert.AreEqual(product, result);
		}

		[TestMethod]
		public void GetProductDescriptoin_ReturnsProductDescription_String()
		{
			string product = "bread";
			string productDescription ="The bread is tasty here.";
			int price = 1;
			string date = "today";
			Order newOrder = new Order(product, productDescription, price, date);
			string result = newOrder.ProductDescription;
			Assert.AreEqual(productDescription, result);
		}
	}
}
