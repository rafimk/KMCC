using MMS.Shared.Abstractions.Exceptions;

namespace MMS.Domain.Exceptions;

public class EmptyDistrictNameException : MMSException
{
    public EmptyDistrictNameException() : base("District name cannot be empty.")
    {
    }
}
