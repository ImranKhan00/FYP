using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FYP.Models
{
    public class DiseasePrecaution
    {
        public int DiseasePrecautionId { get; set; }
        public Disease Disease { get; set; }
        public Precaution Precaution { get; set; }
    }
}
