using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers {

    public class HomeController : Controller {

        public ViewResult Index() {
            int hour = DateTime.Now.Hour;
            string viewModel = hour < 12 ? "Godmorgen" : "God eftermiddag";
            return View("MyView", viewModel);
        }
    }
}
