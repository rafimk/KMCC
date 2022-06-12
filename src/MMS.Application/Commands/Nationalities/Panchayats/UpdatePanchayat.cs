using System;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands.Nationalities.Panchayats;

public record UpdatePanchayat() : ICommand
{
    public Guid Id { get; set;}
    public string Name{ get; set; }
    public Guid MandalamId { get; set; }
    public int Type { get; set; }
}