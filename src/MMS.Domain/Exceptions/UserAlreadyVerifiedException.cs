using System;
using MMS.Shared.Abstractions.Exceptions;

namespace MMS.Domain.Exceptions;

internal sealed class UserAlreadyVerifiedException : MMSException
{
    public string Email { get; }

    public UserAlreadyVerifiedException(string email) : base($"User with Email: '{email}' is already verified.")
    {
        Email = email;
    }
}