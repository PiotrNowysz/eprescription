using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Eprescription.Controllers
{
    public class PrescriptionController : Controller
    {
        private int IndexOfDoctor { get; set; }
        public PrescriptionController()
        {

        }
        public IActionResult Index(int indexOfDoctor, string filterString)
        {
            IndexOfDoctor = indexOfDoctor;
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

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(PrescriptionViewModel prescriptionVm)
        {
            TestDatabase.Doctors.ElementAt(IndexOfDoctor)
                .Prescriptions.Add(prescriptionVm);

            return RedirectToAction("Index");
        }

        public IActionResult View(int indexOfPrescription)
        {
            return RedirectToAction("Index", "Medicine", new { indexOfDoctor = IndexOfDoctor, indexOfPrescription = indexOfPrescription });
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
