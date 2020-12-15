using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FYP.Models
{
    public class Symptoms
    {
        [Key]
        public int SymtomsId { get; set; }
        public string Name { get; set; }
    }
}
