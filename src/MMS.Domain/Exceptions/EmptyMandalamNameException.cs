using MMS.Shared.Abstractions.Exceptions;

namespace MMS.Domain.Exceptions;

public class EmptyMandalamNameException : MMSException
{
    public EmptyMandalamNameException() : base("Mandalam name cannot be empty.")
    {
    }
}
