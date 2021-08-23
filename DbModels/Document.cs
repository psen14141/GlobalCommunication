using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace GloableCommunication.DbModels
{
    [Table("Document")]
    public partial class Document
    {
        public Document()
        {
            TraineeHistories = new HashSet<TraineeHistory>();
        }

        [Key]
        public long DocumentId { get; set; }
        public int DocumentTypeId { get; set; }
        [Required]
        [StringLength(100)]
        public string DocumentName { get; set; }
        [StringLength(250)]
        public string DocumentDescription { get; set; }
        [Required]
        [StringLength(250)]
        public string DocumentFilePath { get; set; }
        public bool DocumentIsDelete { get; set; }
        [Column(TypeName = "date")]
        public DateTime CreateDate { get; set; }

        [ForeignKey(nameof(DocumentTypeId))]
        [InverseProperty("Documents")]
        public virtual DocumentType DocumentType { get; set; }
        [InverseProperty("TrainneDocument")]
        public virtual TraineeDocument TraineeDocument { get; set; }
        [InverseProperty(nameof(TraineeHistory.Document))]
        public virtual ICollection<TraineeHistory> TraineeHistories { get; set; }
    }
}
