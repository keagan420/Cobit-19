using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cobit_19.Models
{
    public class AuditScopeModel
    {
        [Key]
        [ForeignKey("Audit")]
        public int AuditID { get; set; }
        [Key]
        [ForeignKey("Objective")]
        public int ObjectiveID { get; set; }
        public int UserID { get; set; }

        public AuditModel Audits { get; set; }
        public ObjectiveModel Objectives { get; set; }
    }
}
