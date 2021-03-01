using Eprescription.Core;
using Microsoft.AspNetCore.Mvc;

namespace Eprescription.Controllers
{
    public class MedicineController : Controller
    {
        private readonly IMedicineViewModelMapper _medicineViewModelMapper;
        private readonly IMedicineManager _medicineManager;


        public MedicineController(IMedicineViewModelMapper medicineViewModelMapper,
            IMedicineManager medicineManager)
        {
            _medicineViewModelMapper = medicineViewModelMapper;
            _medicineManager = medicineManager;

        }

        public IActionResult Index(string filterString = null)
        {
            var medicineDtos = _medicineManager.GetAllMedicines(filterString);

            var medicineViewModels = _medicineViewModelMapper.Map(medicineDtos);

            return View(medicineViewModels);
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(MedicineViewModel medicineViewModel)
        {
            var medicineDto = _medicineViewModelMapper.Map(medicineViewModel);
            _medicineManager.AddNew(medicineDto);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int medicineId)
        {
            _medicineManager.Delete(new MedicineDto { Id = medicineId });
            return View();
        }
    }
}
