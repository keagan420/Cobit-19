using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cobit_19.Models
{
    public class MapModel
    {
        public MapModel()
        {
        }
        [Key]
        [ForeignKey("Question")]
        public int QuestionID { get; set; } 
        [Key]
        [ForeignKey("Objective")]
        public int ObjectiveID { get; set; }
        [Required]
        [DefaultValue(1)]
        public float Weight { get; set; }

        public QuestionModel Question { get; set; }
        public ObjectiveModel Objective { get; set; }

    }
}
