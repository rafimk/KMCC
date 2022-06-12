using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands.Memberships.Professions;

public record CreateProfession() : ICommand
{
    public string Name{ get; set; }
}