using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cobit_19.Data.Models
{
    public class AuditScopeMembers
    {
        public AuditScopeMembers()
        {
        }

        [Key]
        [ForeignKey("AuditScope")]
        public int AuditScopeID { get; set; }
        [Key]
        [ForeignKey("ApplicationUser")]
        public string ApplicationUserID { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
