using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands.Nationalities.Districts;

public record CreateDistrict() : ICommand
{
    public string Name{ get; set; }
}