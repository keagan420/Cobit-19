namespace Cobit_19.Shared.Dtos
{
    public class FullObjectiveAuditDto
    {
        public string objectiveName { get; set; }
        public string objectiveDescription { get; set; }
        public string objectivePurpose { get; set; }
        public int maturityLevel { get; set; }
        public float maturityLevel0PercFinal { get; set; }
        public float maturityLevel1PercFinal { get; set; }
        public float maturityLevel2PercFinal { get; set; }
        public float maturityLevel3PercFinal { get; set; }
        public float maturityLevel4PercFinal { get; set; }
        public float maturityLevel5PercFinal { get; set; }
        public List<ComponentDto> components { get; set; }
    }
}
