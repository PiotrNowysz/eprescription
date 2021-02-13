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
            if (string.IsNullOrEmpty(filterString))
            {
                return View(TestDatabase.Doctors);
            }

            return View(TestDatabase.Doctors.Where(x => x.Name.Contains(filterString)).ToList());
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
