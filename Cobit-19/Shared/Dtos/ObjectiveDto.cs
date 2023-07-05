using Cobit_19.Data.Models;

namespace Cobit_19.Shared.Dtos
{
    public class ObjectiveDto
    {
        public int ID { get; set; }
        public string Name { get; set; } = default!;
        public string Code { get; set; } = default!;
        public string? Description { get; set; } 
        public ICollection<MapDto>? Maps { get; set; } 
        public ICollection<AuditScopeDto>? AuditScopes { get; set; }
    }
}
