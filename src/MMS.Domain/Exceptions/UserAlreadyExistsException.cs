using MMS.Shared.Abstractions.Exceptions;

namespace MMS.Domain.Exceptions;

internal sealed class UserAlreadyExistsException : MMSException
{
    public string Email { get; }

    public UserAlreadyExistsException(string email) : base($"User with email: '{email}' already exists.")
    {
        Email = email;
    }
}