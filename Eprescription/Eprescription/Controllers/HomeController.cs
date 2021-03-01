using Eprescription.Core;
using Microsoft.AspNetCore.Mvc;

namespace Eprescription.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDoctorManager _doctorManager;
        private readonly IDoctorViewModelMapper _doctorViewModelMapper;

        public HomeController(IDoctorManager doctorManager,
          IDoctorViewModelMapper doctorViewModelMapper)
        {
            _doctorManager = doctorManager;
            _doctorViewModelMapper = doctorViewModelMapper;
        }

        public IActionResult Index(string filterString = null)
        {

            var doctorDtos = _doctorManager.GetAllDoctors(filterString);
            var doctorViewModels = _doctorViewModelMapper.Map(doctorDtos);

            return View(doctorViewModels);

        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(DoctorViewModel doctorViewModel)
        {
            var doctorDto = _doctorViewModelMapper.Map(doctorViewModel);
            _doctorManager.AddNew(doctorDto);

            return RedirectToAction("Index");
        }

        public IActionResult View(int doctorId)
        {
            return RedirectToAction("Index", "Prescription", new { doctorId = doctorId });
        }

        public IActionResult Delete(int doctorId)
        {
            _doctorManager.Delete(new DoctorDto { Id = doctorId });
            var doctorDtos = _doctorManager.GetAllDoctors();
            var doctorViewModels = _doctorViewModelMapper.Map(doctorDtos);

            return View(doctorViewModels);
        }


    }
}
