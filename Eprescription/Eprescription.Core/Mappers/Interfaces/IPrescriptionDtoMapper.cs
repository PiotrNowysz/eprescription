﻿using Eprescription.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eprescription.Core
{
    public interface IPrescriptionDtoMapper : IBaseDtoMapper<Prescription, PrescriptionDto>
    {
    }
}