using Microsoft.AspNetCore.Mvc;

namespace SellingAlbums.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
