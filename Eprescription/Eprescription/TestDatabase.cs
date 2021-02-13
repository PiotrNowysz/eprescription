using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eprescription
{
    public static class TestDatabase
    {
        public static List<DoctorsViewModel> Doctors { get; set; } = new List<DoctorsViewModel>
        {
            new DoctorsViewModel
            {
                Name = "Jan",
                Prescriptions = new List <PrescriptionViewModel>
                {
                    new PrescriptionViewModel
                    {
                        Name = "Recepta1",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name = "Magnez"
                            },
                            new MedicineViewModel
                            {
                                Name = "Aspiryna"
                            }
                        }
                    },
                    new PrescriptionViewModel
                    {
                        Name = "Recepta2",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name = "Acodin"
                            },
                            new MedicineViewModel
                            {
                                Name = "Heroina"
                            }
                        }
                    }
                }
            },
            new DoctorsViewModel
            {
                Name = "Kazimierz",
                Prescriptions = new List<PrescriptionViewModel>
                {
                    new PrescriptionViewModel
                    {
                        Name = "Recepta0",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name = "WitaminaC"
                            },
                            new MedicineViewModel
                            {
                                Name = "Aspiryna"
                            }
                        }
                    },
                    new PrescriptionViewModel
                    {
                        Name = "Recepta2",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name = "Syrop"
                            },
                            new MedicineViewModel
                            {
                                Name = "Morfina"
                            }
                        }
                    }
                }
            },
            new DoctorsViewModel
            {
                Name = "Zbigniew",
                Prescriptions = new List<PrescriptionViewModel>
                {
                    new PrescriptionViewModel
                    {
                        Name = "Recepta1",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name = "WitaminaD"
                            },
                            new MedicineViewModel
                            {
                                Name = "Aspiryna"
                            }
                        }
                    },
                    new PrescriptionViewModel
                    {
                        Name = "Recepta2",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name = "Syrop"
                            },
                            new MedicineViewModel
                            {
                                Name = "Czopki"
                            }
                        }
                    }
                }
            }
        };
    }
}
