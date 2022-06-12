using System;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands.Users;

public record VerifyUser(Guid Id): ICommand;
