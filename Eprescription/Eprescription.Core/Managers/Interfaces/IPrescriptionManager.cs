using System.Collections.Generic;

namespace Eprescription.Core
{
    public interface IPrescriptionManager : IBaseManager<PrescriptionDto>
    {
        IEnumerable<MedicineDto> GetAllMedicinesOfPrescription(int prescriptionId, string filterString);
    }
}