using MMS.Shared.Abstractions.Exceptions;

namespace MMS.Domain.Exceptions;

public class EmptyAreaNameException : MMSException
{
    public EmptyAreaNameException() : base("Area name cannot be empty.")
    {
    }
}
