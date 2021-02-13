using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Eprescription.Controllers
{
    public class PrescriptionController : Controller
    {
        private int IndextOfDoctor { get; set; }
        public PrescriptionController()
        {

        }
        public IActionResult Index(int indexOfDoctor)
        {
            IndextOfDoctor = indexOfDoctor;
            return View(TestDatabase.Doctors.ElementAt(indexOfDoctor));
        }
        public IActionResult View(int indexOfPrescription)
        {
            return RedirectToAction("Index","Medicine", new {indexOfDoctor = IndextOfDoctor, indexOfPrescription = indexOfPrescription });
        }

        private int indexof(DoctorsViewModel doctorVM)
        {
            throw new NotImplementedException();
        }

        public IActionResult Delete(int indexOfPrescription)
        {
            return View();
        }
    }
}
