using Microsoft.AspNetCore.Mvc;

namespace FoxicUI.Areas.Admin.Controllers;
[Area("Admin")]

public class ColorController : Controller
{
	public IActionResult Create()
	{
		return View();
	}
}

