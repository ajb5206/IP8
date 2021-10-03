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
	}
}