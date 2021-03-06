using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands.Users;

public record CreateUser() : ICommand
{
    public string FullName { get; set; }
    public string Email { get; set; }
    public string MobileNumber { get; set; }
    public string AlternativeContactNumber { get; set; }
    public int Role { get; set; }
}
