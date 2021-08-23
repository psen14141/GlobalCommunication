using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace GloableCommunication.DbModels
{
    [Table("SubmissionDbLog")]
    public partial class SubmissionDbLog
    {
        [Key]
        [Column("submissionDbLogId")]
        public long SubmissionDbLogId { get; set; }
        public int? AcceptCompanyDbLog { get; set; }
        public int Userdblog { get; set; }
        public bool StatusDbLog { get; set; }
        [StringLength(50)]
        public string GenerationDbLog { get; set; }
        [Column("entrance_date", TypeName = "date")]
        public DateTime? EntranceDate { get; set; }
        [Column("entry_date", TypeName = "date")]
        public DateTime? EntryDate { get; set; }
        [Column("training3_date", TypeName = "date")]
        public DateTime? Training3Date { get; set; }

        [ForeignKey(nameof(AcceptCompanyDbLog))]
        [InverseProperty(nameof(AcceptingCompany.SubmissionDbLogs))]
        public virtual AcceptingCompany AcceptCompanyDbLogNavigation { get; set; }
        [ForeignKey(nameof(Userdblog))]
        [InverseProperty(nameof(User.SubmissionDbLogs))]
        public virtual User UserdblogNavigation { get; set; }
    }
}
