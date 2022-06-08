using MMS.Shared.Abstractions.Exceptions;

namespace MMS.Domain.Exceptions;

public class EmptyStateNameException : MMSException
{
    public EmptyStateNameException() : base("State name cannot be empty.")
    {
    }
}
