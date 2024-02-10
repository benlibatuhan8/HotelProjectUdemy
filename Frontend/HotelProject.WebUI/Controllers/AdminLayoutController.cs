using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult AdminLayout()
        {
            return View();
        }
        public PartialViewResult HeadPartial()
        {

            return PartialView();
        }
        public PartialViewResult PreLoaderPartial()
        {

            return PartialView();
        }
    }
}
