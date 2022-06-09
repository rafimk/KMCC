using MMS.Shared.Abstractions.Exceptions;

namespace MMS.Domain.Exceptions;

public class InvalidEmiratesIdNumberException : MMSException
{
    public InvalidEmiratesIdNumberException() : base("Invalid emirates id number.")
    {
    }
}