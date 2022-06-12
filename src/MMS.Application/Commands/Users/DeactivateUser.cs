using System;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands.Users;

public record DeactivateUser(Guid Id): ICommand;
