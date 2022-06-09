using MMS.Shared.Abstractions.Exceptions;

namespace MMS.Domain.Exceptions;

public class EmptyProfessionNameException : MMSException
{
    public EmptyProfessionNameException() : base("Profession name cannot be empty.")
    {
    }
}
