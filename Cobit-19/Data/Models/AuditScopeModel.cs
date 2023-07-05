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
        [ForeignKey("Audit")]
        public int AuditID { get; set; }
        [Key]
        [ForeignKey("Objective")]
        public int ObjectiveID { get; set; }
        [ForeignKey("ApplicationUser")]
        public string ApplicationUserID { get; set; }

        public virtual AuditModel Audit { get; set; }
        public virtual ObjectiveModel Objective { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
