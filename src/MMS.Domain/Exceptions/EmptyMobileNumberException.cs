using MMS.Shared.Abstractions.Exceptions;

namespace MMS.Domain.Exceptions;

public class EmptyMobileNumberException : MMSException
{
    public EmptyMobileNumberException() : base("Mobile number cannot be empty.")
    {
    }
}