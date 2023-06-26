namespace Cobit_19.Models
{
    public class ObjectiveModel
    {
        public ObjectiveModel()
        {
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public virtual ICollection<MapModel> Maps { get; set; }
        public virtual ICollection<AuditScopeModel> AuditScopes { get; set; }
    }
}
