using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DateTimeParser.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index(string parseThis)
		{
			if (String.IsNullOrEmpty(parseThis)) return View();
			ViewBag.ParseThis = parseThis;
			DateTime result;
			if (DateTime.TryParse(parseThis, out result))
			{
				ViewBag.Output = result.ToLongDateString() + " " + result.ToLongTimeString();
				ViewBag.Success = true;
			}
			else
			{
				ViewBag.Success = false;
			}
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "About";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Questions?";

			return View();
		}
	}
}