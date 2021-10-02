using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using PierreTracker.Models;

namespace PierreTracker.Controllers
{
	public class VendorController : Controller
	{
		[HttpGet("/vendors")]
		public ActionResult Index()
		{
			List<Vendor> allVendors = Vendor.GetAll();
			return View(allVendors);
		}

		[HttpGet("/vendors/new")]
		public ActionResult New()
		{
			return View();
		}

		[HttpPost("vendors")]
		public ActionResult Create(string vendorName, string description)
		{
			Vendor newVendor = new Vendor(vendorName, description);
			return RedirectToAction("Index");
		}
	}
}