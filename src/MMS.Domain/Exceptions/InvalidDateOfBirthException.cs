using MMS.Shared.Abstractions.Exceptions;

namespace MMS.Domain.Exceptions;

public class InvalidDateOfBirthException : MMSException
{
    public InvalidDateOfBirthException() : base("The date of birth can not be in the future.")
    {
    }
}