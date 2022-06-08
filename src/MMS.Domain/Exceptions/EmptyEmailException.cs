using MMS.Shared.Abstractions.Exceptions;

namespace MMS.Domain.Exceptions;

public class EmptyEmailException : MMSException
{
    public EmptyEmailException() : base("Email cannot be empty.")
    {
    }
}