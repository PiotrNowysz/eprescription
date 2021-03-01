using Eprescription.Database;
using System.Collections.Generic;
using System.Linq;

namespace Eprescription.Core
{
    public class MedicineManager : BaseManager<Medicine, MedicineDto>, IMedicineManager
    {
        private readonly IMedicineRepository _medicineRepository;
        private readonly IMedicineDtoMapper _medicineDtoMapper;

        public MedicineManager(IMedicineRepository medicineRepository,
            IMedicineDtoMapper medicineDtoMapper) : base(medicineDtoMapper, medicineRepository)
        {
            _medicineDtoMapper = medicineDtoMapper;
            _medicineRepository = medicineRepository;
        }

        public IEnumerable<MedicineDto> GetAllMedicines(string filterString = null)
        {
            var medicineEntities = _medicineRepository.GetAll();

            if (!string.IsNullOrEmpty(filterString))
            {
                medicineEntities = medicineEntities.Where(x => x.Name.Contains(filterString) || 
                x.Composition.Contains(filterString) ||
                x.ProducentName.Contains(filterString));
            }
            return _medicineDtoMapper.Map(medicineEntities);
        }
    }
}
