using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Eprescription.Controllers
{
    public class MedicineController : Controller
    {
        private int IndexOfDoctor { get; set; }
        private int IndexOfPrescription { get; set; }
        public MedicineController()
        {

        }
        public IActionResult Index(int indexOfDoctor, int indexOfPrescription, string filterString)
        {
            IndexOfDoctor = indexOfDoctor;
            IndexOfPrescription = indexOfPrescription;
            if (string.IsNullOrEmpty(filterString))
            {
                return View(TestDatabase.Doctors.ElementAt(indexOfDoctor).Prescriptions.ElementAt(indexOfPrescription));
            }

            return View(new PrescriptionViewModel
            {
                Name = TestDatabase.Doctors.ElementAt(indexOfDoctor).Prescriptions.ElementAt(indexOfPrescription).Name,
                Medicines = TestDatabase.Doctors.ElementAt(indexOfDoctor).Prescriptions.ElementAt(indexOfPrescription).Medicines.Where(x => x.Name.Contains(filterString)).ToList()
            });
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(MedicineViewModel medicineVm)
        {
            TestDatabase.Doctors.ElementAt(IndexOfDoctor)
                .Prescriptions.ElementAt(IndexOfPrescription)
                .Medicines.Add(medicineVm);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int indexOfMedicine)
        {
            return View();
        }
    }
}
