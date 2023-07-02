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
        [ForeignKey("FocusAreas")]
        public int FocusAreaID { get; set; }
        public int UserID { get; set; }
        [Required]
        public string Name { get; set; }
        public AuditStatus Status { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateCreated { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateCompleted { get; set; }

        public virtual FocusAreaModel FocusAreas { get; set; }
        public ICollection<AuditScopeModel> AuditScopes { get; set; }
        public ICollection<AnswerModel> Answers { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

    }
}
