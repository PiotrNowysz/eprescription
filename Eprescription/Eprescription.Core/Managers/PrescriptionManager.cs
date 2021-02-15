using Eprescription.Database;
using System.Collections.Generic;
using System.Linq;

namespace Eprescription.Core
{
    public class PrescriptionManager : BaseManager<Prescription, PrescriptionDto>, IPrescriptionManager
    {

        private readonly IPrescriptionRepository _prescriptionRepository;
        private readonly PrescriptionDtoMapper _prescriptionMapper;
        private readonly IMedicineRepository _medicineRepository;
        private readonly MedicineDtoMapper _medicineMapper;

        public PrescriptionManager(IPrescriptionRepository prescriptionRepository, PrescriptionDtoMapper prescriptionMapper,
            IMedicineRepository medicineRepository, MedicineDtoMapper medicineMapper,
            IRepository<Prescription> repository, IBaseDtoMapper<Prescription, PrescriptionDto> baseMapper) : base(repository, baseMapper)
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

    }
}
