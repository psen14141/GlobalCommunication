using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace GloableCommunication.DbModels
{
    [Table("DocumentType")]
    public partial class DocumentType
    {
        public DocumentType()
        {
            Documents = new HashSet<Document>();
        }

        [Key]
        public int DocumentTypeId { get; set; }
        [Required]
        [StringLength(100)]
        public string DocumentTypeName { get; set; }
        [Required]
        [StringLength(250)]
        public string DocumentTypeDescription { get; set; }
        public bool DcouemntTypeIsDelete { get; set; }

        [InverseProperty(nameof(Document.DocumentType))]
        public virtual ICollection<Document> Documents { get; set; }
    }
}
