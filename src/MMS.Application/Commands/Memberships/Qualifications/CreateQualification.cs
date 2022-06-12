using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands.Memberships.Qualifications;

public record CreateQualification() : ICommand
{
    public string Name{ get; set; }
}