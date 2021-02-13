using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Eprescription.Controllers
{
    public class MedicineController : Controller
    {
        public MedicineController()
        {

        }
        public IActionResult Index(int indexOfDoctor, int indexOfPrescription)
        {
            return View(TestDatabase.Doctors.ElementAt(indexOfDoctor).Prescriptions.ElementAt(indexOfPrescription));
        }

        public IActionResult Delete(int indexOfMedicine)
        {
            return View();
        }
    }
}
