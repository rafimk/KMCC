using System;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands;

public record UpdatePanchayat() : ICommand
{
    public Guid Id { get; set;}
    public string Name{ get; set; }
    public Guid MandalamId { get; set; }
    public Int Type { get; set; }
}