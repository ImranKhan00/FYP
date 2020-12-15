using FYP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FYP.DAL
{
    public class HealthAnalyzerDataContext:DbContext
    {
        public HealthAnalyzerDataContext(DbContextOptions<HealthAnalyzerDataContext> options)
            :base(options)
        {
        }
        //Here We Should Define DbSets<> For The Presprective Classes
       public  DbSet<Disease> Diseases { get; set; }
       public  DbSet<Cure> Cures { get; set; }
       public  DbSet<Diagnosis> Diagnoses { get; set; }
       public  DbSet<DiseaseCure> DiseaseCures { get; set; }
       public  DbSet<DiseasePrecaution> DiseasePrecautions { get; set; }
       public  DbSet<DiseaseSymptoms> DiseaseSymptoms { get; set; }
       public  DbSet<Precaution> Precautions { get; set; }
       public  DbSet<Symptoms> Symptoms { get; set; }
       public  DbSet<User> Users { get; set; }
    }
}
