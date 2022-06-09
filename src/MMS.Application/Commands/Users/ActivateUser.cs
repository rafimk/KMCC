using System;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands;

public record ActivateUser(Guid Id): ICommand;
