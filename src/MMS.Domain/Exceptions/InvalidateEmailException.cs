using MMS.Shared.Abstractions.Exceptions;

namespace MMS.Domain.Exceptions;

public class InvalidateEmailException : MMSException
{
    public InvalidateEmailException() : base("Invalid email address.")
    {
    }
}