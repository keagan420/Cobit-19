using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Reflection.Emit;

namespace Cobit_19.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<FocusAreaModel> FocusAreas { get; set; }
        public DbSet<AuditModel> Audits { get; set; }
        public DbSet<DesignFactorModel> DesignFactors { get; set; }
        public DbSet<QuestionModel> Questions { get; set; }
        public DbSet<ObjectiveModel> Objectives { get; set; }
        public DbSet<AnswerModel> Answers { get; set; }
        public DbSet<AuditScopeModel> AuditScopes { get; set; }
        public DbSet<MapModel> Maps { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Table names

            builder.Entity<FocusAreaModel>().ToTable("FocusAreas");
            builder.Entity<AuditModel>().ToTable("Audits");
            builder.Entity<DesignFactorModel>().ToTable("DesignFactors");
            builder.Entity<QuestionModel>().ToTable("Questions");
            builder.Entity<ObjectiveModel>().ToTable("Objectives");
            builder.Entity<AnswerModel>().ToTable("Answers");
            builder.Entity<AuditScopeModel>().ToTable("AuditScopes");
            builder.Entity<MapModel>().ToTable("Maps");

            // Relationships

            builder.Entity<AnswerModel>()
                .HasKey(table => new {
                    table.AuditID,
                    table.QuestionID
            });

            builder.Entity<AnswerModel>()
               .HasOne(d => d.Audit)
               .WithMany(d => d.Answers)
               .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<AnswerModel>()
               .HasOne(d => d.Question)
               .WithMany(d => d.Answers)
               .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<AuditScopeModel>().HasKey(table => new {
                table.AuditID,
                table.ObjectiveID
            });

            builder.Entity<MapModel>().HasKey(table => new {
                table.ObjectiveID,
                table.QuestionID
            });

            // Data seeding

            builder.Entity<FocusAreaModel>().HasData(
                new FocusAreaModel { ID = 1, Name = "Cobit Core Model", Description = "General Core Model", DateCreated = DateTime.Parse("Jan 1, 2009") });

            builder.Entity<DesignFactorModel>().HasData(
                new DesignFactorModel { ID = 1, FocusAreaID = 1, Name = "EDM01", Description = "Ensure Governance Framework Setting and Maintenance" }
                );

            builder.Entity<QuestionModel>().HasData(
                new QuestionModel { ID = 1, DesignFactorID = 1, Question = "Is there a governance framework that includes the organisational structure, as well as the assignment of authorities and responsibilities for executing governance activities and monitoring their adequacy and effectiveness?", DefaultAnswer = 1 }
                );

            builder.Entity<AuditModel>().HasData(
                new AuditModel { ID = 1, FocusAreaID = 1, UserID = 1, Name = "Audit 1", DateCreated = DateTime.Parse("Jan 1, 2009"), Status = AuditStatus.InProgress }
                );
            builder.Entity<AnswerModel>().HasData(
                new AnswerModel { AuditID = 1, QuestionID = 1, Answer = 1 }
                );
        }

    }
}
