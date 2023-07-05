namespace Cobit_19.Shared.Dtos
{
    public class QuestionDto
    { 
        public int ID { get; set; }
        public string Question { get; set; } = default!;
        public AnswerDto Answer { get; set; } = default!;
        public IEnumerable<MapDto>? Maps { get; set; } = default!;
    }
}
