using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace GloableCommunication.DbModels
{
    [Table("Submission")]
    public partial class Submission
    {
        [Key]
        public int SubmissionId { get; set; }
        public int AcceptingcompanyId { get; set; }
        [StringLength(10)]
        public string Generation { get; set; }
        [Column("statusFlag")]
        public bool StatusFlag { get; set; }
        public bool DeleteFlag { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EntranceDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EntryDate { get; set; }
        [Column("Trainning3_Date", TypeName = "date")]
        public DateTime? Trainning3Date { get; set; }

        [ForeignKey(nameof(AcceptingcompanyId))]
        [InverseProperty(nameof(AcceptingCompany.Submissions))]
        public virtual AcceptingCompany Acceptingcompany { get; set; }
    }
}
