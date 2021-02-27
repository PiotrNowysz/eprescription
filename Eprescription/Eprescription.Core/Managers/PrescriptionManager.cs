using Eprescription.Database;
using System.Collections.Generic;
using System.Linq;

namespace Eprescription.Core
{
    public class PrescriptionManager : IPrescriptionManager
    {

        private readonly IPrescriptionRepository _prescriptionRepository;
        private readonly IPrescriptionDtoMapper _prescriptionMapper;
        private readonly IMedicineRepository _medicineRepository;
        private readonly IMedicineDtoMapper _medicineMapper;

        public PrescriptionManager(IPrescriptionRepository prescriptionRepository, IPrescriptionDtoMapper prescriptionMapper,
            IMedicineRepository medicineRepository, IMedicineDtoMapper medicineMapper)
        {
            _prescriptionRepository = prescriptionRepository;
            _prescriptionMapper = prescriptionMapper;
            _medicineRepository = medicineRepository;
            _medicineMapper = medicineMapper;
        }

        public IEnumerable<MedicineDto> GetAllMedicinesOfPrescription(int prescriptionId, string filterString)
        {
            var prescriptionEntity = _prescriptionRepository.GetAll().FirstOrDefault(x => x.Id == prescriptionId);
            var medicineEntities = prescriptionEntity.MedicinePrescriptions.Select(x => x.Medicine);

            if (!string.IsNullOrEmpty(filterString))
            {
                medicineEntities = medicineEntities
                    .Where(x =>
                    x.Name.Contains(filterString) ||
                    x.Composition.Contains(filterString) ||
                    x.ProducentName.Contains(filterString));
            }

            return _medicineMapper.Map(medicineEntities);
        }
        public bool AddNew(PrescriptionDto prescriptonDto)
        {
            var entity = _prescriptionMapper.Map(prescriptonDto);
            return _prescriptionRepository.AddNew(entity);
        }

        public bool Delete(PrescriptionDto prescriptonDto)
        {
            var entity = _prescriptionMapper.Map(prescriptonDto);
            return _prescriptionRepository.Delete(entity);
        }
    }
}
