using MMS.Shared.Abstractions.Exceptions;

namespace MMS.Domain.Exceptions;

public class InvalidPassportExpiryException : MMSException
{
    public InvalidPassportExpiryException() : base("Invalid passport expiry/expired")
    {
    }
}