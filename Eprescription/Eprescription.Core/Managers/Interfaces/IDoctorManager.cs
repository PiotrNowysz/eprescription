using System.Collections.Generic;

namespace Eprescription.Core
{
    public interface IDoctorManager : IBaseManager<DoctorDto>
    {
        IEnumerable<DoctorDto> GetAllDoctors(string filterString = null);
        IEnumerable<PrescriptionDto> GetAllPrescriptonsOfDoctor(int doctorId, string filterString = null);
    }
}
