using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cobit_19.Models
{
    public class AnswerModel
    {
        public AnswerModel()
        {
        }
        [Key]
        [Column(Order = 1)]
        [ForeignKey("Audit")]
        public int AuditID { get; set; }
        [Key]
        [Column(Order =2)]
        [ForeignKey("Question")]
        public int QuestionID { get; set; }
        [DefaultValue(0)]
        public int Answer { get; set; }

        public AuditModel Audit { get; set; }
        public QuestionModel Question { get; set; }
    }
}
