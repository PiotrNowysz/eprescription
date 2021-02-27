using Eprescription.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eprescription.Core
{
    public class MedicineManager : BaseManager<Medicine, MedicineDto>, IMedicineManager
    {

        public MedicineManager(IMedicineRepository medicineRepository,
            IMedicineDtoMapper medicineMapper) : base(medicineMapper, medicineRepository)
        {
        }
        //public bool AddNew(MedicineDto medicineDto)
        //{
        //    var entity = _medicineMapper.Map(medicineDto);
        //    return _medicineRepository.AddNew(entity);
        //}

        //public bool Delete(MedicineDto medicineDto)
        //{
        //    var entity = _medicineMapper.Map(medicineDto);
        //    return _medicineRepository.Delete(entity);
        //}
    }
}
