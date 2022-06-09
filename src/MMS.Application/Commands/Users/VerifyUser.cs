using System;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands;

public record VerifyUser(Guid Id): ICommand;
