using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace GloableCommunication.DbModels
{
    [Table("Perfecture")]
    public partial class Perfecture
    {
        public Perfecture()
        {
            AcceptingCompanyPerfectures = new HashSet<AcceptingCompany>();
            AcceptingCompanyTrainingPrefectureCdNavigations = new HashSet<AcceptingCompany>();
        }

        [Key]
        public int PerfectureId { get; set; }
        public int PerfectureCode { get; set; }
        [Required]
        [StringLength(50)]
        public string PerfectureName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime InsertDatetTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDateTime { get; set; }
        public int AreaId { get; set; }
        public bool IsDeletePerfecture { get; set; }

        [ForeignKey(nameof(AreaId))]
        [InverseProperty("Perfectures")]
        public virtual Area Area { get; set; }
        [InverseProperty(nameof(AcceptingCompany.Perfecture))]
        public virtual ICollection<AcceptingCompany> AcceptingCompanyPerfectures { get; set; }
        [InverseProperty(nameof(AcceptingCompany.TrainingPrefectureCdNavigation))]
        public virtual ICollection<AcceptingCompany> AcceptingCompanyTrainingPrefectureCdNavigations { get; set; }
    }
}
