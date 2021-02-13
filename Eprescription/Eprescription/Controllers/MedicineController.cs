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
        public IActionResult Index(int indexOfDoctor, int indexOfPrescription, string filterString)
        {
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

        public IActionResult Delete(int indexOfMedicine)
        {
            return View();
        }
    }
}
