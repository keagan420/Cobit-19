using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cobit_19.Models
{
    public class QuestionModel
    {
        public QuestionModel()
        {
        }
        public int ID { get; set; }
        public int DesignFactorID { get; set; }
        [Required]
        public string Question { get; set; }
        public int? DefaultAnswer { get; set; }

        public virtual DesignFactorModel DesignFactor { get; set; }
        public virtual ICollection<MapModel> Maps { get; set; }
        public virtual ICollection<AnswerModel> Answers { get; set; }
    }
}
