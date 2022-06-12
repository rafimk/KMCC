using System;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands.Nationalities.Areas;

public record DeleteArea(Guid Id): ICommand;