using MMS.Shared.Abstractions.Exceptions;

namespace MMS.Domain.Exceptions;

public class InvalidateMobileNumberException : MMSException
{
    public InvalidateMobileNumberException() : base("Invalid mobile number.")
    {
    }
}