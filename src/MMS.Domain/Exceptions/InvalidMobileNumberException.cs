using MMS.Shared.Abstractions.Exceptions;

namespace MMS.Domain.Exceptions;

public class InvalidMobileNumberException : MMSException
{
    public InvalidMobileNumberException() : base("Invalid mobile number.")
    {
    }
}