using MMS.Shared.Abstractions.Exceptions;

namespace MMS.Domain.Exceptions;

public class EmptyPanchayatNameException : MMSException
{
    public EmptyPanchayatNameException() : base("Panchayat name cannot be empty.")
    {
    }
}
