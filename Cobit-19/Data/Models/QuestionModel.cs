using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cobit_19.Data.Models
{
    public class QuestionModel : AppModel<int>
    {
        public QuestionModel()
        {
        }
        public int DesignFactorID { get; set; }
        [Required]
        public string Question { get; set; }

        public virtual DesignFactorModel DesignFactor { get; set; }
        public ICollection<MapModel> Maps { get; set; }
        public ICollection<AnswerModel> Answers { get; set; }
    }
}
