using Eprescription.Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Eprescription.Controllers
{

    public class PrescriptionController : Controller
    {
        private readonly IPrescriptionManager _prescriptionManager;
        private readonly IPrescriptionViewModelMapper _prescriptionViewModelMapper;
        private readonly IDoctorManager _doctorManager;
        private int _doctorId;

        public PrescriptionController(IPrescriptionManager prescriptionManager,
            IPrescriptionViewModelMapper prescriptionViewModelMapper,
            IDoctorManager doctorManager)
        {
            _prescriptionManager = prescriptionManager;
            _prescriptionViewModelMapper = prescriptionViewModelMapper;
            _doctorManager = doctorManager;
        }

        public IActionResult Index(int doctorId, string filterString = null)
        {
            _doctorId = doctorId;

            var prescriptionDtos = _doctorManager.GetAllPrescriptonsOfDoctor(doctorId, filterString);

            var prescriptionViewModel = _prescriptionViewModelMapper.Map(prescriptionDtos);

            return View(prescriptionViewModel);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(PrescriptionViewModel prescriptionViewModel)
        {
            var prescriptionDto = _prescriptionViewModelMapper.Map(prescriptionViewModel);
            _prescriptionManager.AddNew(prescriptionDto);

            return RedirectToAction("Index");
        }

        public IActionResult View(int prescriptionId)
        {
            return RedirectToAction("Index", "Medicine", new { doctorId = _doctorId, prescriptionId = prescriptionId });
        }

        private int indexof(DoctorsViewModel doctorVM)
        {
            throw new NotImplementedException();
        }

        public IActionResult Delete(int prescriptionId)
        {
            _prescriptionManager.Delete(new PrescriptionDto { Id = prescriptionId });

            return View();
        }
    }

}
