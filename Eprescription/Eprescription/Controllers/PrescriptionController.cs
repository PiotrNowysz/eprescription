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
        public IActionResult Index(int indexOfDoctor, string filterString)
        {
            IndextOfDoctor = indexOfDoctor;
            if (string.IsNullOrEmpty(filterString))
            {
                return View(TestDatabase.Doctors.ElementAt(indexOfDoctor));
            }

            return View(new DoctorsViewModel
            {
                Name = TestDatabase.Doctors.ElementAt(indexOfDoctor).Name,
                Prescriptions = TestDatabase.Doctors.ElementAt(indexOfDoctor).Prescriptions.Where(x => x.Name.Contains(filterString)).ToList()
            });


        }
        public IActionResult View(int indexOfPrescription)
        {
            return RedirectToAction("Index", "Medicine", new { indexOfDoctor = IndextOfDoctor, indexOfPrescription = indexOfPrescription });
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
