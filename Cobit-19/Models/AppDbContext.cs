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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AnswerModel>().HasKey(table => new {
                table.AuditID,
                table.QuestionID
            });

            builder.Entity<AuditScopeModel>().HasKey(table => new {
                table.AuditID,
                table.ObjectiveID
            });

            builder.Entity<MapModel>().HasKey(table => new {
                table.ObjectiveID,
                table.QuestionID
            });
        }

        public DbSet<FocusAreaModel> FocusAreas { get; set; }
        public DbSet<AuditModel> Audits { get; set; }
        public DbSet<DesignFactorModel> DesignFactors { get; set; }
        public DbSet<QuestionModel> Questions { get; set; }
        public DbSet<ObjectiveModel> Objectives { get; set; }
        public DbSet<AnswerModel> Answers { get; set; }
        public DbSet<AuditScopeModel> AuditScopes { get; set; }
        public DbSet<MapModel> Maps { get; set; }
    }
}
