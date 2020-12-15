using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FYP.Models
{
    public class DiseaseSymptoms
    {
        public int DiseaseSymptomsId { get; set; }
        public Disease Disease { get; set; }
        public Symptoms Symptoms { get; set; }
        public string Severity { get; set; }
    }
}
