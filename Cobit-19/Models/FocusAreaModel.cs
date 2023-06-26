using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cobit_19.Models
{
    public class FocusAreaModel
    {
        public FocusAreaModel()
        {
        }

        public int ID { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateCreated { get; set; }

        public virtual ICollection<AuditModel> Audits { get; set; }
        public virtual ICollection<DesignFactorModel> DesignFactors { get; set; }
    }
}
