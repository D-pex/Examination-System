namespace Examination.Core.Dtos;

public sealed class TestDto(
    int id,
    string name,
    string subject,
    string? description,
    int duration,
    bool isPublished,
    DateTime createdAt
)
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
    public string Subject { get; set; } = subject;
    public string? Description { get; set; } = description;
    public int Duration { get; set; } = duration;
    public bool IsPublished { get; set; } = isPublished;
    public DateTime CreatedAt { get; set; } = createdAt;
}