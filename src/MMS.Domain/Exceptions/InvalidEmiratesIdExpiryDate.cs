using MMS.Shared.Abstractions.Exceptions;

namespace MMS.Domain.Exceptions;

public class InvalidEmiratesIdExpiryDate : MMSException
{
    public InvalidEmiratesIdExpiryDate() : base("Invalid emirates id  expiry date/expired.")
    {
    }
}