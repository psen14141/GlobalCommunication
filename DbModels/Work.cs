using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace GloableCommunication.DbModels
{
    [Table("Work")]
    public partial class Work
    {
        public Work()
        {
            TraineeMasters = new HashSet<TraineeMaster>();
        }

        [Key]
        public int WorkId { get; set; }
        [Required]
        [StringLength(50)]
        public string WorkName { get; set; }
        public int OccupationId { get; set; }
        [Column(TypeName = "date")]
        public DateTime InsertDateTime { get; set; }
        [Column(TypeName = "date")]
        public DateTime? UpdateDateTime { get; set; }
        [Column("Verifcation_Name")]
        [StringLength(100)]
        public string VerifcationName { get; set; }
        public bool IsDeleteWork { get; set; }

        [ForeignKey(nameof(OccupationId))]
        [InverseProperty("Works")]
        public virtual Occupation Occupation { get; set; }
        [InverseProperty(nameof(TraineeMaster.Work))]
        public virtual ICollection<TraineeMaster> TraineeMasters { get; set; }
    }
}
