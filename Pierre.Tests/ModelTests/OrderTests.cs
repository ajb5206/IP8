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
		public void GetProductDescription_ReturnsProductDescription_String()
		{
			string product = "bread";
			string productDescription ="The bread is tasty here.";
			int price = 1;
			string date = "today";
			Order newOrder = new Order(product, productDescription, price, date);
			string result = newOrder.ProductDescription;
			Assert.AreEqual(productDescription, result);
		}

		[TestMethod]
		public void GetPrice_ReturnsPrice_Int()
		{
			string product = "bread";
			string productDescription ="The bread is tasty here.";
			int price = 1;
			string date = "today";
			Order newOrder = new Order(product, productDescription, price, date);
			int result = newOrder.Price;
			Assert.AreEqual(price, result);
		}

		[TestMethod]
		public void GetDate_ReturnsDate_String()
		{
			string product = "bread";
			string productDescription ="The bread is tasty here.";
			int price = 1;
			string date = "today";
			Order newOrder = new Order(product, productDescription, price, date);
			string result = newOrder.Date;
			Assert.AreEqual(date, result);
		}

		[TestMethod]
		public void SetProduct_SetProduct_String()
		{
			string product = "bread";
			string productDescription ="The bread is tasty here.";
			int price = 1;
			string date = "today";
			Order newOrder = new Order(product, productDescription, price, date);
			string updatedProduct = "pastries";
			newOrder.Product = updatedProduct;
			string result = newOrder.Product;
			Assert.AreEqual(updatedProduct, result);
		}

		[TestMethod]
		public void SetProdcutDescription_SetProductDescription_String()
		{
			string product = "bread";
			string productDescription ="The bread is tasty here.";
			int price = 1;
			string date = "today";
			Order newOrder = new Order(product, productDescription, price, date);
			string updatedProductDescription = "The pastries are tasty here";
			newOrder.ProductDescription = updatedProductDescription;
			string result = newOrder.ProductDescription;
			Assert.AreEqual(updatedProductDescription, result);
		}

		[TestMethod]
		public void SetPrice_SetPrice_Int()
		{
			string product = "bread";
			string productDescription ="The bread is tasty here.";
			int price = 1;
			string date = "today";
			Order newOrder = new Order(product, productDescription, price, date);
			int updatedPrice = 5;
			newOrder.Price = updatedPrice;
			int result = newOrder.Price;
			Assert.AreEqual(updatedPrice, result);
		}

		[TestMethod]
		public void SetDate_SetDate_String()
		{
			string product = "bread";
			string productDescription ="The bread is tasty here.";
			int price = 1;
			string date = "today";
			Order newOrder = new Order(product, productDescription, price, date);
			string updatedDate = "tomorrow";
			newOrder.Date = updatedDate;
			string result = newOrder.Date;
			Assert.AreEqual(updatedDate, result);
		}

		[TestMethod]
		public void GetAll_ReturnsEmptyList_OrderList()
		{
			List<Order> newOrderList = new List<Order> {};
			List<Order> result = Order.GetAll();
			CollectionAssert.AreEqual(newOrderList, result);
		}

		[TestMethod]
		public void GetAll_ReturnsOrder_OrderList()
		{
			string product01 = "bread";
			string productDescription01 = "bread tasty";
			int price01 = 1;
			string date01 = "today";
			string product02 = "pastries";
			string productDescription02 = "pastries tasty";
			int price02 = 2;
			string date02 = "tomorrow";
			Order newOrder1 = new Order(product01, productDescription01, price01, date01);
			Order newOrder2 = new Order(product02, productDescription02, price02, date02);
			List<Order> newOrder = new List<Order> { newOrder1, newOrder2 };
			List<Order> result = Order.GetAll();
			CollectionAssert.AreEqual(newOrder, result);
		}

		[TestMethod]
		public void GetId_OrdersInstantiatedWithanIdandGetterReturns_Int()
		{
			string product = "bread";
			string productDescription = "is tasty";
			int price = 1;
			string date = "today";
			Order newOrder = new Order(product, productDescription, price, date);
			int result = newOrder.Id;
			Assert.AreEqual(1, result);
		}

		[TestMethod]
		public void Find_ReturnsCorrectOrder_Order()
		{
			string product01 = "bread";
			string productDescription01 = "bread tasty";
			int price01 = 1;
			string date01 = "today";
			string product02 = "pastries";
			string productDescription02 = "pastries tasty";
			int price02 = 2;
			string date02 = "tomorrow";
			Order newOrder1 = new Order(product01, productDescription01, price01, date01);
			Order newOrder2 = new Order(product02, productDescription02, price02, date02);
			Order result = Order.Find(2);
			Assert.AreEqual(newOrder2, result);
		}
	}
}
