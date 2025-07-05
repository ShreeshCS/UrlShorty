using Microsoft.AspNetCore.Mvc;
using UrlShorty.Client.Data.Models;

namespace UrlShorty.Client.Controllers
{
	public class UrlController : Controller
	{
		public IActionResult Index()
		{
			Url url = new Url()
			{
				OriginalUrl = "https://example.com",
				ShortenedUrl = "exmpl",
			};
			return View(url);
		}
	}
}
