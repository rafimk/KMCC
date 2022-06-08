using MMS.Shared.Abstractions.Exceptions;

namespace MMS.Domain.Exceptions;

public class EmptyFullNameException : MMSException
{
    public EmptyFullNameException() : base("Full name cannot be empty.")
    {
    }
}