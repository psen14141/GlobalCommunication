using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace GloableCommunication.DbModels
{
    [Table("ConfirmUser")]
    public partial class ConfirmUser
    {
        [Key]
        public int ConfirmId { get; set; }
        public int UserId { get; set; }
        public bool ConfirmFlag { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty("ConfirmUsers")]
        public virtual User User { get; set; }
    }
}
