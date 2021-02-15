using Eprescription.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eprescription.Core
{
    public class MedicineManager : BaseManager<Medicine, MedicineDto>
    {
        public MedicineManager(IRepository<Medicine> repository, IBaseDtoMapper<Medicine, MedicineDto> baseMapper) : base(repository, baseMapper)
        {

        }
    }
}
