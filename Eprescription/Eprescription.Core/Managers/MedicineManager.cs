using Eprescription.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eprescription.Core
{
    public class MedicineManager : IMedicineManager
    {
        private readonly IMedicineRepository _medicineRepository;
        private readonly IMedicineDtoMapper _medicineMapper;
        public MedicineManager(IMedicineRepository repository, IMedicineDtoMapper mapper)
        {
            _medicineRepository = repository;
            _medicineMapper = mapper;

        }
        public bool AddNew(MedicineDto medicineDto)
        {
            var entity = _medicineMapper.Map(medicineDto);
            return _medicineRepository.AddNew(entity);
        }

        public bool Delete(MedicineDto medicineDto)
        {
            var entity = _medicineMapper.Map(medicineDto);
            return _medicineRepository.Delete(entity);
        }
    }
}
