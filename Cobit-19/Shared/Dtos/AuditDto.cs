using Cobit_19.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Cobit_19.Shared.Enums;

namespace Cobit_19.Shared.Dtos
{
    public class AuditDto
    {
        public int ID { get; set; }
        public int FocusAreaID { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; } = default!;
        public AuditStatus Status { get; set; } = default!;
        public DateTime DateCreated { get; set; }
        public DateTime? DateCompleted { get; set; }
        public List<AnswerDto>? Answers { get; set; } 
    }
}
