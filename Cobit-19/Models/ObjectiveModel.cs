using System.ComponentModel.DataAnnotations;

namespace Cobit_19.Models
{
    public class ObjectiveModel
    {
        public ObjectiveModel()
        {
        }

        public int ID { get; set; }
        public string Name { get; set; }
        [Required]
        public string Code { get; set; }
        public string? Description { get; set; }

        public ICollection<MapModel> Maps { get; set; }
        public ICollection<AuditScopeModel> AuditScopes { get; set; }
    }
}
