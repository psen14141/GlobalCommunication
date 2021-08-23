using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace GloableCommunication.DbModels
{
    [Table("TraineeDocument")]
    public partial class TraineeDocument
    {
        [Key]
        public long TrainneDocumentId { get; set; }
        public long TraineeId { get; set; }
        public long DocumentId { get; set; }

        [ForeignKey(nameof(TraineeId))]
        [InverseProperty(nameof(TraineeMaster.TraineeDocuments))]
        public virtual TraineeMaster Trainee { get; set; }
        [ForeignKey(nameof(TrainneDocumentId))]
        [InverseProperty(nameof(Document.TraineeDocument))]
        public virtual Document TrainneDocument { get; set; }
    }
}
