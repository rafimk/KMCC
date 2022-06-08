using MMS.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions;

public class EmptyGenericIdException : MMSException
{
    public EmptyGenericIdException() : base("ID cannot be empty.")
    {
    }
}
