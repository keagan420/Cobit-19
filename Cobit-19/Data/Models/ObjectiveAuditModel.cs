using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cobit_19.Data.Models
{
    public class ObjectiveAuditModel
    {
        public ObjectiveAuditModel()
        {
        }
        [Key]
        public int ObjectiveAuditID { get; set; }
        [ForeignKey("AuditScope")]
        public int AuditScopeID { get; set; }
        [ForeignKey("FocusArea")]
        public int FocusAreaID { get; set; }
        [Column(TypeName = "varchar(MAX)")]
        public string AuditObject { get; set; }
    }
}
