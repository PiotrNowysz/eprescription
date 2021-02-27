using Eprescription.Database;
using System.Collections.Generic;
using System.Linq;

namespace Eprescription.Core
{
    public class DoctorManager : BaseManager<Doctor, DoctorDto>, IDoctorManager
    {
        private readonly IDoctorRepository _doctorRepository;
        private readonly IDoctorDtoMapper _doctorMapper;
        private readonly IPrescriptionRepository _prescriptionRepository;
        private readonly IPrescriptionDtoMapper _prescriptionMapper;

        public DoctorManager(IDoctorRepository doctorRepository,
            IDoctorDtoMapper doctorMapper,
            IPrescriptionRepository prescriptionRepository,
            IPrescriptionDtoMapper prescriptionMapper) : base(doctorMapper, doctorRepository)
        {
            _doctorRepository = doctorRepository;
            _doctorMapper = doctorMapper;
            _prescriptionRepository = prescriptionRepository;
            _prescriptionMapper = prescriptionMapper;
        }

        public IEnumerable<DoctorDto> GetAllDoctors(string filterString)
        {
            var doctorEntities = _doctorRepository.GetAll();

            if (!string.IsNullOrEmpty(filterString))
            {
                doctorEntities = doctorEntities.Where(x => x.FirstName.Contains(filterString) || x.LastName.Contains(filterString));
            }
            return _doctorMapper.Map(doctorEntities);
        }

        public IEnumerable<PrescriptionDto> GetAllPrescriptonsOfDoctor(int doctorId, string filterString)
        {
            var prescriptionEntities = _prescriptionRepository.GetAll().Where(x => x.DoctorId == doctorId);

            if (!string.IsNullOrEmpty(filterString))
            {
                prescriptionEntities = prescriptionEntities.Where(x => x.Name.Contains(filterString));
            }
            return _prescriptionMapper.Map(prescriptionEntities);
        }
        //public bool AddNew(DoctorDto doctorDto)
        //{
        //    var entity = _doctorMapper.Map(doctorDto);
        //    return _doctorRepository.AddNew(entity);
        //}

        //public bool Delete(DoctorDto doctorDto)
        //{
        //    var entity = _doctorMapper.Map(doctorDto);
        //    return _doctorRepository.Delete(entity);
        //}

    }
}
