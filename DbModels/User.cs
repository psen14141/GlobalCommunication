using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace GloableCommunication.DbModels
{
    [Table("User")]
    public partial class User
    {
        public User()
        {
            ConfirmStatuses = new HashSet<ConfirmStatus>();
            ConfirmUsers = new HashSet<ConfirmUser>();
            SubmissionDbLogs = new HashSet<SubmissionDbLog>();
        }

        [Key]
        public int UserId { get; set; }
        [Required]
        [StringLength(100)]
        public string UserCode { get; set; }
        [Required]
        [StringLength(10)]
        public string Password { get; set; }
        [Column("Access_Flag")]
        public int? AccessFlag { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime InsertDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDateTime { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        public bool IsDeleteUser { get; set; }

        [InverseProperty(nameof(ConfirmStatus.User))]
        public virtual ICollection<ConfirmStatus> ConfirmStatuses { get; set; }
        [InverseProperty(nameof(ConfirmUser.User))]
        public virtual ICollection<ConfirmUser> ConfirmUsers { get; set; }
        [InverseProperty(nameof(SubmissionDbLog.UserdblogNavigation))]
        public virtual ICollection<SubmissionDbLog> SubmissionDbLogs { get; set; }
    }
}
