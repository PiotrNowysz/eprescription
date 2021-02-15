using System;
using System.Collections.Generic;
using System.Text;

namespace Eprescription.Core
{
    public interface IDoctorManager : IBaseManager<DoctorDto>
    {
        IEnumerable<DoctorDto> GetAllDoctors(string filterString);
        IEnumerable<PrescriptionDto> GetAllPrescriptonsOfDoctor(int doctorId, string filterString);
    }
}
