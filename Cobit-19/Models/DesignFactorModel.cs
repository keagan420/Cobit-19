using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cobit_19.Models
{
    public class DesignFactorModel
    {
        public DesignFactorModel()
        {
        }

        public int ID { get; set; }
        public int FocusAreaID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        
        public virtual FocusAreaModel FocusArea { get; set; }
        public virtual ICollection<QuestionModel> Questions { get; set; }
    }
}
