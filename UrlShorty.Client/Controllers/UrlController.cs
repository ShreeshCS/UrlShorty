using Microsoft.AspNetCore.Mvc;

namespace UrlShorty.Client.Controllers
{
	public class UrlController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
