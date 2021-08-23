using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace GloableCommunication.DbModels
{
    [Table("Occupation")]
    public partial class Occupation
    {
        public Occupation()
        {
            TraineeMasters = new HashSet<TraineeMaster>();
            Works = new HashSet<Work>();
        }

        [Key]
        public int OccupationId { get; set; }
        public int OccupationCode { get; set; }
        [Required]
        [StringLength(50)]
        public string OccupationName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime InsertDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDateTime { get; set; }
        [Column("TraineeYear_Flag")]
        public long? TraineeYearFlag { get; set; }
        public bool IsDeleteOccupation { get; set; }

        [InverseProperty(nameof(TraineeMaster.Occupation))]
        public virtual ICollection<TraineeMaster> TraineeMasters { get; set; }
        [InverseProperty(nameof(Work.Occupation))]
        public virtual ICollection<Work> Works { get; set; }
    }
}
