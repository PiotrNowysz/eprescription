using AutoMapper;
using Eprescription.Database;
using System.Collections.Generic;

namespace Eprescription.Core
{
    public class MedicineDtoMapper
    {
        private IMapper _mapper;

        public MedicineDtoMapper()
        {
            _mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<Medicine, MedicineDto>().ForMember(x => x.TotalPrice, options => options
                 .MapFrom(y => y.Price * y.Amount)).ReverseMap();
            }).CreateMapper();
        }

        #region Maps
        public MedicineDto Map(Medicine medicine)
            => _mapper.Map<MedicineDto>(medicine);

        public IEnumerable<MedicineDto> Map(IEnumerable<Medicine> medicines)
            => _mapper.Map<IEnumerable<MedicineDto>>(medicines);

        public Medicine Map(MedicineDto medicineDto)
            => _mapper.Map<Medicine>(medicineDto);

        public IEnumerable<Medicine> Map(IEnumerable<MedicineDto> medicineDtos)
            => _mapper.Map<IEnumerable<Medicine>>(medicineDtos);
        #endregion
    }
}