﻿using System;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands.Memberships;

public record DeactivateMemberships(Guid Id): ICommand;