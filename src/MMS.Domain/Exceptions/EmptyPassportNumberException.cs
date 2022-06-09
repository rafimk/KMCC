using MMS.Shared.Abstractions.Exceptions;

namespace MMS.Domain.Exceptions;

public class EmptyPassportNumberException : MMSException
{
    public EmptyPassportNumberException() : base("Passport number cannot be empty.")
    {
    }
}
