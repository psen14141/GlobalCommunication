using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace GloableCommunication.DbModels
{
    public partial class GCommunicationContext : DbContext
    {
        public GCommunicationContext()
        {
        }

        public GCommunicationContext(DbContextOptions<GCommunicationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AcceptingCompany> AcceptingCompanies { get; set; }
        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<AssetManagement> AssetManagements { get; set; }
        public virtual DbSet<ConfirmStatus> ConfirmStatuses { get; set; }
        public virtual DbSet<ConfirmUser> ConfirmUsers { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<DocumentType> DocumentTypes { get; set; }
        public virtual DbSet<Occupation> Occupations { get; set; }
        public virtual DbSet<Perfecture> Perfectures { get; set; }
        public virtual DbSet<SendingCompany> SendingCompanies { get; set; }
        public virtual DbSet<Submission> Submissions { get; set; }
        public virtual DbSet<SubmissionDbLog> SubmissionDbLogs { get; set; }
        public virtual DbSet<TraineeDocument> TraineeDocuments { get; set; }
        public virtual DbSet<TraineeHistory> TraineeHistories { get; set; }
        public virtual DbSet<TraineeMaster> TraineeMasters { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Work> Works { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //                optionsBuilder.UseSqlServer("Data Source=DESKTOP-1H7H1RK;Initial Catalog=GCommunication;User ID=sa;Password=abc123;Trusted_Connection=True;MultipleActiveResultSets=True;");
                IConfiguration configuration = Startup.LocalConfigurtation;
                string value = configuration.GetConnectionString("GCommunicationContext");

                optionsBuilder.UseSqlServer(value);

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<AcceptingCompany>(entity =>
            {
                entity.Property(e => e.AcceptiingCompanyName).IsFixedLength(true);

                entity.Property(e => e.AcceptingCompanyCode).IsFixedLength(true);

                entity.Property(e => e.Address1).IsFixedLength(true);

                entity.Property(e => e.Address2).IsFixedLength(true);

                entity.Property(e => e.Business).IsFixedLength(true);

                entity.Property(e => e.Charge).IsFixedLength(true);

                entity.Property(e => e.ChargePosition).IsFixedLength(true);

                entity.Property(e => e.ChargeTelephone).IsFixedLength(true);

                entity.Property(e => e.CheifExecutiveOfficer).IsFixedLength(true);

                entity.Property(e => e.Documents).IsFixedLength(true);

                entity.Property(e => e.DocumentsPosition).IsFixedLength(true);

                entity.Property(e => e.DocumentsTel).IsFixedLength(true);

                entity.Property(e => e.EnglishName).IsFixedLength(true);

                entity.Property(e => e.Fax).IsFixedLength(true);

                entity.Property(e => e.HiraganaName).IsFixedLength(true);

                entity.Property(e => e.Instructor1).IsFixedLength(true);

                entity.Property(e => e.Instructor2).IsFixedLength(true);

                entity.Property(e => e.Instructor3).IsFixedLength(true);

                entity.Property(e => e.InstructorPosition1).IsFixedLength(true);

                entity.Property(e => e.InstructorPosition2).IsFixedLength(true);

                entity.Property(e => e.InstructorPosition3).IsFixedLength(true);

                entity.Property(e => e.InstructorTel1).IsFixedLength(true);

                entity.Property(e => e.InstructorTel2).IsFixedLength(true);

                entity.Property(e => e.InstructorTel3).IsFixedLength(true);

                entity.Property(e => e.IpNotificationNo).IsFixedLength(true);

                entity.Property(e => e.Limit).IsFixedLength(true);

                entity.Property(e => e.Member).IsFixedLength(true);

                entity.Property(e => e.Mentor).IsFixedLength(true);

                entity.Property(e => e.MentorPosition).IsFixedLength(true);

                entity.Property(e => e.MentorTel).IsFixedLength(true);

                entity.Property(e => e.Sales).IsFixedLength(true);

                entity.Property(e => e.SalesPosition).IsFixedLength(true);

                entity.Property(e => e.TelephoneNo).IsFixedLength(true);

                entity.Property(e => e.TrainingAdress1).IsFixedLength(true);

                entity.Property(e => e.TrainingAdress2).IsFixedLength(true);

                entity.Property(e => e.TrainingFax).IsFixedLength(true);

                entity.Property(e => e.TrainingTel).IsFixedLength(true);

                entity.Property(e => e.TrainingZip).IsFixedLength(true);

                entity.Property(e => e.Zip).IsFixedLength(true);

                entity.Property(e => e.ＬtdCd).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.AcceptingCompanies)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("_Area_AcceptingCompany");

                entity.HasOne(d => d.Perfecture)
                    .WithMany(p => p.AcceptingCompanyPerfectures)
                    .HasForeignKey(d => d.PerfectureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PerfectureAcceptingCompany");

                entity.HasOne(d => d.TrainingPrefectureCdNavigation)
                    .WithMany(p => p.AcceptingCompanyTrainingPrefectureCdNavigations)
                    .HasForeignKey(d => d.TrainingPrefectureCd)
                    .HasConstraintName("FK_Perfecture_AcceptingCompany");
            });

            modelBuilder.Entity<Area>(entity =>
            {
                entity.Property(e => e.AreaName).IsFixedLength(true);

                entity.Property(e => e.InsertDateTime).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Areas)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Country_Area");
            });

            modelBuilder.Entity<AssetManagement>(entity =>
            {
                entity.Property(e => e.Generation).IsFixedLength(true);

                entity.HasOne(d => d.AcceptingCompany)
                    .WithMany(p => p.AssetManagements)
                    .HasForeignKey(d => d.AcceptingCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcceptingCompany_AssetManagement");

                entity.HasOne(d => d.SendingCompny)
                    .WithMany(p => p.AssetManagements)
                    .HasForeignKey(d => d.SendingCompnyId)
                    .HasConstraintName("FK_SendingCompany_AssetManagement");
            });

            modelBuilder.Entity<ConfirmStatus>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.ConfirmStatuses)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_ConfirmStatus");
            });

            modelBuilder.Entity<ConfirmUser>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.ConfirmUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_ConfirmUser");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.CountryName).IsFixedLength(true);

                entity.Property(e => e.InsertDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DocumentDescription).IsFixedLength(true);

                entity.Property(e => e.DocumentFilePath).IsFixedLength(true);

                entity.Property(e => e.DocumentName).IsFixedLength(true);

                entity.HasOne(d => d.DocumentType)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.DocumentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocumentType_Document");
            });

            modelBuilder.Entity<DocumentType>(entity =>
            {
                entity.Property(e => e.DocumentTypeDescription).IsFixedLength(true);

                entity.Property(e => e.DocumentTypeName).IsFixedLength(true);
            });

            modelBuilder.Entity<Occupation>(entity =>
            {
                entity.Property(e => e.InsertDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OccupationName).IsFixedLength(true);
            });

            modelBuilder.Entity<Perfecture>(entity =>
            {
                entity.Property(e => e.InsertDatetTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PerfectureName).IsFixedLength(true);

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.Perfectures)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Area_Perfecture");
            });

            modelBuilder.Entity<SendingCompany>(entity =>
            {
                entity.Property(e => e.Address1).IsFixedLength(true);

                entity.Property(e => e.Address2).IsFixedLength(true);

                entity.Property(e => e.Charge).IsFixedLength(true);

                entity.Property(e => e.ChargeTelephone).IsFixedLength(true);

                entity.Property(e => e.CheifExecutiveOfficer).IsFixedLength(true);

                entity.Property(e => e.Fax).IsFixedLength(true);

                entity.Property(e => e.Fullname).IsFixedLength(true);

                entity.Property(e => e.SendingComapny).IsFixedLength(true);

                entity.Property(e => e.SendingName).IsFixedLength(true);

                entity.Property(e => e.Telephone).IsFixedLength(true);

                entity.Property(e => e.Zip).IsFixedLength(true);

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.SendingCompanies)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Area_SendingCompany");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.SendingCompanies)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CountrySendingCompany_");
            });

            modelBuilder.Entity<Submission>(entity =>
            {
                entity.Property(e => e.Generation).IsFixedLength(true);

                entity.HasOne(d => d.Acceptingcompany)
                    .WithMany(p => p.Submissions)
                    .HasForeignKey(d => d.AcceptingcompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKCompany_Submission_Accepting");
            });

            modelBuilder.Entity<SubmissionDbLog>(entity =>
            {
                entity.Property(e => e.GenerationDbLog).IsFixedLength(true);

                entity.HasOne(d => d.AcceptCompanyDbLogNavigation)
                    .WithMany(p => p.SubmissionDbLogs)
                    .HasForeignKey(d => d.AcceptCompanyDbLog)
                    .HasConstraintName("FK__AcceptingCompany_SubmissionDbLog");

                entity.HasOne(d => d.UserdblogNavigation)
                    .WithMany(p => p.SubmissionDbLogs)
                    .HasForeignKey(d => d.Userdblog)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubmissionDbLog_User");
            });

            modelBuilder.Entity<TraineeDocument>(entity =>
            {
                entity.Property(e => e.TrainneDocumentId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.TraineeDocuments)
                    .HasForeignKey(d => d.TraineeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TraineeDocument_TraineeMaster");

                entity.HasOne(d => d.TrainneDocument)
                    .WithOne(p => p.TraineeDocument)
                    .HasForeignKey<TraineeDocument>(d => d.TrainneDocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TraineeDocument_Document");
            });

            modelBuilder.Entity<TraineeHistory>(entity =>
            {
                entity.Property(e => e.Career1).IsFixedLength(true);

                entity.Property(e => e.Career2).IsFixedLength(true);

                entity.Property(e => e.Career3).IsFixedLength(true);

                entity.Property(e => e.Career4).IsFixedLength(true);

                entity.Property(e => e.Career5).IsFixedLength(true);

                entity.Property(e => e.Career6).IsFixedLength(true);

                entity.Property(e => e.Career7).IsFixedLength(true);

                entity.Property(e => e.Career8).IsFixedLength(true);

                entity.Property(e => e.Career9).IsFixedLength(true);

                entity.Property(e => e.CheckPlan).HasDefaultValueSql("((0))");

                entity.Property(e => e.DesactvisaImg1).IsFixedLength(true);

                entity.Property(e => e.DesactvisaImg2).IsFixedLength(true);

                entity.Property(e => e.HomecmpAdress1).IsFixedLength(true);

                entity.Property(e => e.HomecmpAdress2).IsFixedLength(true);

                entity.Property(e => e.HomecmpBusiness).IsFixedLength(true);

                entity.Property(e => e.HomecmpName).IsFixedLength(true);

                entity.Property(e => e.HomecmpTel).IsFixedLength(true);

                entity.Property(e => e.HomecmpZip).IsFixedLength(true);

                entity.Property(e => e.LandingPermit).IsFixedLength(true);

                entity.Property(e => e.Other1).IsFixedLength(true);

                entity.Property(e => e.Other2).IsFixedLength(true);

                entity.Property(e => e.PassportImg).IsFixedLength(true);

                entity.Property(e => e.PassportNo).IsFixedLength(true);

                entity.Property(e => e.RegistrationImg1).IsFixedLength(true);

                entity.Property(e => e.RegistrationImg2).IsFixedLength(true);

                entity.Property(e => e.RegistrationNo).IsFixedLength(true);

                entity.Property(e => e.ResidentCard2).IsFixedLength(true);

                entity.Property(e => e.ResidentCardNo).IsFixedLength(true);

                entity.Property(e => e.Residentcard3).IsFixedLength(true);

                entity.Property(e => e.Residentcard4).IsFixedLength(true);

                entity.Property(e => e.Residentcard5).IsFixedLength(true);

                entity.Property(e => e.Residentcardyear2).IsFixedLength(true);

                entity.Property(e => e.Residentcardyear3).IsFixedLength(true);

                entity.Property(e => e.Residentcardyear4).IsFixedLength(true);

                entity.Property(e => e.Residentcardyesr5).IsFixedLength(true);

                entity.Property(e => e.TraineevisaImg1).IsFixedLength(true);

                entity.Property(e => e.TraineevisaImg2).IsFixedLength(true);

                entity.Property(e => e.VisitFlg).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.TraineeHistories)
                    .HasForeignKey(d => d.DocumentId)
                    .HasConstraintName("F_DocumentK_TraineeHistory");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.TraineeHistories)
                    .HasForeignKey(d => d.TraineeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("_TraineeMaster_TraineeHistory");
            });

            modelBuilder.Entity<TraineeMaster>(entity =>
            {
                entity.Property(e => e.Address1).IsFixedLength(true);

                entity.Property(e => e.Address2).IsFixedLength(true);

                entity.Property(e => e.BirthPlace).IsFixedLength(true);

                entity.Property(e => e.BirthdayByEra).IsFixedLength(true);

                entity.Property(e => e.BloodTypeFlg).IsFixedLength(true);

                entity.Property(e => e.Certification1No).IsFixedLength(true);

                entity.Property(e => e.Certification2No).IsFixedLength(true);

                entity.Property(e => e.Certification3No).IsFixedLength(true);

                entity.Property(e => e.Classname1).IsFixedLength(true);

                entity.Property(e => e.Classname2).IsFixedLength(true);

                entity.Property(e => e.Colum).IsFixedLength(true);

                entity.Property(e => e.DeathComments).IsFixedLength(true);

                entity.Property(e => e.DelayedEntry).IsFixedLength(true);

                entity.Property(e => e.DeleteFlg).HasDefaultValueSql("((0))");

                entity.Property(e => e.Email).IsFixedLength(true);

                entity.Property(e => e.EmergencyTel).IsFixedLength(true);

                entity.Property(e => e.EntranceStatus).IsFixedLength(true);

                entity.Property(e => e.Generation).IsFixedLength(true);

                entity.Property(e => e.Immigrationstatus).IsFixedLength(true);

                entity.Property(e => e.JapaneseDate).IsFixedLength(true);

                entity.Property(e => e.KanjiName).IsFixedLength(true);

                entity.Property(e => e.KatakanaName).IsFixedLength(true);

                entity.Property(e => e.MReturnComments).IsFixedLength(true);

                entity.Property(e => e.NewOldSystem).IsFixedLength(true);

                entity.Property(e => e.PensionNo).IsFixedLength(true);

                entity.Property(e => e.Position).IsFixedLength(true);

                entity.Property(e => e.PositionStatus).IsFixedLength(true);

                entity.Property(e => e.RentFlg).HasDefaultValueSql("((0))");

                entity.Property(e => e.Result).IsFixedLength(true);

                entity.Property(e => e.Result2).IsFixedLength(true);

                entity.Property(e => e.ReturnComments).IsFixedLength(true);

                entity.Property(e => e.Schlarship).IsFixedLength(true);

                entity.Property(e => e.SexFlag).IsFixedLength(true);

                entity.Property(e => e.SpouseFlg).IsFixedLength(true);

                entity.Property(e => e.SprintComments).IsFixedLength(true);

                entity.Property(e => e.TelephoneNo).IsFixedLength(true);

                entity.Property(e => e.Testname).IsFixedLength(true);

                entity.Property(e => e.TraineeImage).IsFixedLength(true);

                entity.Property(e => e.TraineeName).IsFixedLength(true);

                entity.Property(e => e.TraineeNo).IsFixedLength(true);

                entity.Property(e => e.TransfersComments).IsFixedLength(true);

                entity.Property(e => e.UtilitycostsFlg).HasDefaultValueSql("((0))");

                entity.Property(e => e.Zip).IsFixedLength(true);

                entity.HasOne(d => d.AcceptingCompany)
                    .WithMany(p => p.TraineeMasters)
                    .HasForeignKey(d => d.AcceptingCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AcceptingCompany_TraineeMaster");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TraineeMasters)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Country_TraineeMaster");

                entity.HasOne(d => d.Occupation)
                    .WithMany(p => p.TraineeMasters)
                    .HasForeignKey(d => d.OccupationId)
                    .HasConstraintName("FK_Occupation_TraineeMaster");

                entity.HasOne(d => d.SendingCompany)
                    .WithMany(p => p.TraineeMasters)
                    .HasForeignKey(d => d.SendingCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SendingCompany_TraineeMaster");

                entity.HasOne(d => d.Work)
                    .WithMany(p => p.TraineeMasters)
                    .HasForeignKey(d => d.WorkId)
                    .HasConstraintName("FK_Work_TraineeMaster");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Email).IsFixedLength(true);

                entity.Property(e => e.InsertDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Password).IsFixedLength(true);

                entity.Property(e => e.UserCode).IsFixedLength(true);
            });

            modelBuilder.Entity<Work>(entity =>
            {
                entity.Property(e => e.InsertDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VerifcationName).IsFixedLength(true);

                entity.Property(e => e.WorkName).IsFixedLength(true);

                entity.HasOne(d => d.Occupation)
                    .WithMany(p => p.Works)
                    .HasForeignKey(d => d.OccupationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Occupation_Work");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
