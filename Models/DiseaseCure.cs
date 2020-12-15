using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FYP.Models
{
    public class DiseaseCure
    {
        public int DiseaseCureId { get; set; }
        public Disease Disease { get; set; }
        public Cure Cure { get; set; }
    }
}
