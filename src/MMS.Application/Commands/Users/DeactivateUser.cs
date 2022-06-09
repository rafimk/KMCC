using System;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands;

public record DeactivateUser(Guid Id): ICommand;
