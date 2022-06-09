using MMS.Shared.Abstractions.Exceptions;

namespace MMS.Domain.Exceptions;

public class EmptyEmiratesIdNumberException : MMSException
{
    public EmptyEmiratesIdNumberException() : base("Emirates Id Number cannot be empty.")
    {
    }
}