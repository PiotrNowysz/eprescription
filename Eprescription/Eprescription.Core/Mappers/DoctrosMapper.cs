using AutoMapper;
using Eprescription.Database;
using System.Collections.Generic;

namespace Eprescription.Core.Mappers
{
    public class DoctrosMapper
    {
        private IMapper _mapper;

        public DoctrosMapper()
        {
            _mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<Medicine, MedicineDto>().ForMember(x => x.TotalPrice, options => options
                 .MapFrom(y => y.Price * y.Amount)).ReverseMap();
                config.CreateMap<Doctor, DoctorDto>().ReverseMap();
                config.CreateMap<PrescriptionDto, Prescription>().ReverseMap();
                config.CreateMap<MedicinePrescription, MedicinePrescriptionDto>().ReverseMap();
            }).CreateMapper();
        }

        #region Medicine Maps

        public MedicineDto Map(Medicine medicine)
            => _mapper.Map<MedicineDto>(medicine);

        public IEnumerable<MedicineDto> Map(IEnumerable<Medicine> medicines)
            => _mapper.Map<IEnumerable<MedicineDto>>(medicines);

        public Medicine Map(MedicineDto medicineDto)
            => _mapper.Map<Medicine>(medicineDto);

        public IEnumerable<Medicine> Map(IEnumerable<MedicineDto> medicineDtos)
            => _mapper.Map<IEnumerable<Medicine>>(medicineDtos);

        #endregion

        #region Doctor Maps
        public DoctorDto Map(Doctor doctor)
            => _mapper.Map<DoctorDto>(doctor);

        public IEnumerable<DoctorDto> Map(IEnumerable<Doctor> doctors)
            => _mapper.Map<IEnumerable<DoctorDto>>(doctors);

        public Doctor Map(DoctorDto doctorDto)
            => _mapper.Map<Doctor>(doctorDto);

        public IEnumerable<Doctor> Map(IEnumerable<DoctorDto> doctorDtos)
            => _mapper.Map<IEnumerable<Doctor>>(doctorDtos);
        #endregion

        #region Prescription Maps

        public PrescriptionDto Map(Prescription prescription)
            => _mapper.Map<PrescriptionDto>(prescription);

        public IEnumerable<PrescriptionDto> Map(IEnumerable<Prescription> prescriptions)
            => _mapper.Map<IEnumerable<PrescriptionDto>>(prescriptions);

        public Prescription Map(PrescriptionDto prescriptioneDto)
            => _mapper.Map<Prescription>(prescriptioneDto);

        public IEnumerable<Prescription> Map(IEnumerable<PrescriptionDto> prescriptionDtos)
            => _mapper.Map<IEnumerable<Prescription>>(prescriptionDtos);
        #endregion

        #region MedicinePrescription Maps
        public MedicinePrescriptionDto Map(MedicinePrescription medicinePrescription)
            => _mapper.Map<MedicinePrescriptionDto>(medicinePrescription);

        public IEnumerable<MedicinePrescriptionDto> Map(IEnumerable<MedicinePrescription> medicinePrescriptions)
            => _mapper.Map<IEnumerable<MedicinePrescriptionDto>>(medicinePrescriptions);

        public MedicinePrescription Map(MedicinePrescriptionDto medicinePrescriptionDto)
            => _mapper.Map<MedicinePrescription>(medicinePrescriptionDto);

        public IEnumerable<MedicinePrescription> Map(IEnumerable<MedicinePrescriptionDto> medicinePrescriptionDtos)
            => _mapper.Map<IEnumerable<MedicinePrescription>>(medicinePrescriptionDtos);
        #endregion
    }
}
