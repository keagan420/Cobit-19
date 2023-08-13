using Cobit_19.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cobit_19.Shared.Dtos
{
    public class ObjectiveAuditMemberDto
    {
        public int ID { get; set; }
        public int ObjectiveAuditID { get; set; }
        public string ApplicationUserID { get; set; }
        public DateTime DateAdded { get; set; }

        public ObjectiveAuditModel ObjectiveAudit { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
