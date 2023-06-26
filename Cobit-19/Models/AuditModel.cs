using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cobit_19.Models
{
    public enum AuditStatus
    {
        InProgress = 0,
        Completed = 1
    }
    public class AuditModel
    {
        public AuditModel()
        {
        }
        public int ID { get; set; }
        public int FocusAreaID { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; }
        public AuditStatus Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateCompleted { get; set; }

        public virtual FocusAreaModel FocusAreas { get; set; }
        public virtual ICollection<AuditScopeModel> AuditScopes { get; set; }
        public virtual ICollection<AnswerModel> Answers { get; set; }

    }
}
