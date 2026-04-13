public sealed class ReportDto
{
    public int TestId { get; set; }
    public string TestName { get; set; } = string.Empty;
    public int TotalAttempts { get; set; }
    public int PassedCount { get; set; }
    public int FailedCount { get; set; }
    public double AverageScore { get; set; }
}