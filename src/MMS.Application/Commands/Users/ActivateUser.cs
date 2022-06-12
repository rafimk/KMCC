using System;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands.Users;

public record ActivateUser(Guid Id): ICommand;
