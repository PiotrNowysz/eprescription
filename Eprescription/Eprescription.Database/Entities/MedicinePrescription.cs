﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Eprescription
{
    public class MedicinePrescription
    {
        public int MedicineId { get; set; }
        public Medicine Medicine { get; set; }
        public int PrescriptionId { get; set; }
        public Prescription Prescription { get; set; }
    }
}
