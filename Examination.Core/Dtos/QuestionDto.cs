namespace Examination.Core.Dtos;

public sealed class QuestionDto(
    int id,
    string questionText,
    List<OptionDto> options
)
{
    public int Id { get; set; } = id;
    public string QuestionText { get; set; } = questionText;
    public List<OptionDto> Options { get; set; } = options;
}