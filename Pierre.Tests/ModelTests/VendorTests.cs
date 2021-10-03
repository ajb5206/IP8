using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreTracker.Models;
using System.Collections.Generic;
using System;

namespace PierreTracker.Tests
{
	[TestClass]
	public class CategoryTests : IDisposable
	{
		
		public void Dispose()
		{
			Vendor.ClearAll();
		}

		[TestMethod]
		public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
		{
			Vendor newVendor = new Vendor("test vendor", "test description");
			Assert.AreEqual(typeof(Vendor), newVendor.GetType());
		}

		[TestMethod]
		public void GetVendorName_ReturnsVendorName_String()
		{
			string vendorName = "Test Vendor";
			string description = "Test description";
			Vendor newVendor = new Vendor(vendorName, description);
			string result = newVendor.VendorName;
			Assert.AreEqual(vendorName, result);
		}

		[TestMethod]
		public void GetDescription_ReturnsDescription_String()
		{
			string vendorName = "Test Vendor";
			string description = "Test description";
			Vendor newVendor = new Vendor(vendorName, description);
			string result = newVendor.Description;
			Assert.AreEqual(description, result);
		}

		[TestMethod]
		public void GetAll_ReturnsAllVendorObjects_VendorList()
		{
			string vendorName01 = "Bob's";
			string description01 = "Burgers";
			string vendorName02 = "Wendy's";
			string description02 = "French Fries";
			Vendor newVendor1 = new Vendor(vendorName01, description01);
			Vendor newVendor2 = new Vendor(vendorName02, description02);
			List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2};
			List<Vendor> result = Vendor.GetAll();
			CollectionAssert.AreEqual(newList, result);
		}

		[TestMethod]
		public void Find_ReturnsCorrectVendor_Vendor()
		{
			string vendorName01 = "Bob's";
			string description01 = "Burgers";
			string vendorName02 = "Wendy's";
			string description02 = "French Fries";
			Vendor newVendor1 = new Vendor(vendorName01, description01);
			Vendor newVendor2 = new Vendor(vendorName02, description02);
			Vendor result = Vendor.Find(2);
			Assert.AreEqual(newVendor2, result);
		}

		[TestMethod]
		public void AddOrder_AssociatesOrderWithVendor_OrderList()
		{
			string product = "bread";
			string productDescription = "is tasty";
			int price = 1;
			string date = "today";
			Order newOrder = new Order(product, productDescription, price, date);
			List<Order> newOrderList = new List<Order> { newOrder };
			string vendorName = "Bob's";
			string description = "sells the best burgers";
			Vendor newVendor = new Vendor(vendorName, description);
			newVendor.AddOrder(newOrder);
			List<Order> result = newVendor.Orders;
			CollectionAssert.AreEqual(newOrderList, result);
		}
	}
}