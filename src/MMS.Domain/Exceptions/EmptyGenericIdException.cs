using MMS.Shared.Abstractions.Exceptions;

namespace MMS.Domain.Exceptions;

public class EmptyGenericIdException : MMSException
{
    public EmptyGenericIdException() : base("ID cannot be empty.")
    {
    }
}
