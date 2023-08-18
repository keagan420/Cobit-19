namespace Cobit_19.Shared.Dtos
{
    public class ComponentQuestionDto
    {
        public string questionType { get; set; }
        public string questionDescription { get; set; }
        public int questionAnswer { get; set; }
        public float questionScore { get; set; }
        public string? questionComment { get; set; }
    }
}
