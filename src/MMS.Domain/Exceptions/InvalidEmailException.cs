using MMS.Shared.Abstractions.Exceptions;

namespace MMS.Domain.Exceptions;

public class InvalidEmailException : MMSException
{
    public InvalidEmailException() : base("Invalid email address.")
    {
    }
}