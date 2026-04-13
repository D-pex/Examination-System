namespace Examination.Core.Requests;

public sealed class CreateLoginRequest
{
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}