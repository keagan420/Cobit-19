using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cobit_19.Data.Models
{
    public class AuditScopeModel
    {
        public AuditScopeModel()
        {
        }
        [Key]
        public int AuditScopeID { get; set; }
        [ForeignKey("Audit")]
        public int AuditID { get; set; }
        [ForeignKey("Objective")]
        public int ObjectiveID { get; set; }
        [ForeignKey("ApplicationUser")]
        public string ApplicationUserID { get; set; }
        public bool Selected { get; set; }
        public int Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateCompleted { get; set; }

        public virtual AuditModel Audit { get; set; }
        public virtual ObjectiveModel Objective { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
