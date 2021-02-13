using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Eprescription.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public IActionResult Index(string filterString)
        {
            return View(TestDatabase.Doctors);
            
        }

        public IActionResult View(int indexOfDoctor)
        {
            return RedirectToAction("Index", "Prescription", new { indexOfDoctor = indexOfDoctor });
        }

        public IActionResult Delete(int indexOfDoctor)
        {
            return View(TestDatabase.Doctors);
        }


    }
}
