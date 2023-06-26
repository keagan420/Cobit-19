using System.ComponentModel.DataAnnotations;

namespace Cobit_19.Data
{
    public class FocusAreaModel
    {
        public FocusAreaModel()
        {
        }

        [Key]
        public string FocusID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string userID { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
