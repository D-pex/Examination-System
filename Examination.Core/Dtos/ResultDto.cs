namespace Examination.Core.Dtos;

public sealed class ResultDto
{
    public int AttemptId { get; set; }
    public int UserId { get; set; }
    public string UserName { get; set; } = string.Empty;
    public int TestId { get; set; }
    public string TestName { get; set; } = string.Empty;
    public int TotalScore { get; set; }
    public bool IsPassed { get; set; }
    public DateTime AttemptDate { get; set; }
}