﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Eprescription
{
    public class Doctor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsAbleToMakePrescription { get; set; }

        [NotMapped]
        public virtual List<Prescription> Prescriptions { get; set; }
    }
}
