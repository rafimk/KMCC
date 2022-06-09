using MMS.Shared.Abstractions.Exceptions;

namespace MMS.Domain.Exceptions;

public class EmptyQualificationNameException : MMSException
{
    public EmptyQualificationNameException() : base("Qualification name cannot be empty.")
    {
    }
}
