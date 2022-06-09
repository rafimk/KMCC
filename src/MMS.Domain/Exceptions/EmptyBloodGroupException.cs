using MMS.Shared.Abstractions.Exceptions;

namespace MMS.Domain.Exceptions;

public class EmptyBloodGroupException : MMSException
{
    public EmptyBloodGroupException() : base("Blood group cannot be empty.")
    {
    }
}