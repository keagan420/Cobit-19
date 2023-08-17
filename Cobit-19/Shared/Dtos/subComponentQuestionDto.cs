namespace Cobit_19.Shared.Dtos
{
    public class subComponentQuestionDto
    {
        public string questionType { get; set; }
        public string questionDescription { get; set; }
        public string? relatedGuidance { get; set; }
        public string? detailedReference { get; set; }
        public string? inputFrom { get; set; }
        public string? inputTo { get; set; }
        public int questionAnswer { get; set; }
        public int questionScore { get; set; }
        public string? questionComment { get; set; }

    }
}
