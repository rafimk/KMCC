using MMS.Shared.Abstractions.Exceptions;

namespace MMS.Domain.Exceptions;

public class EmptyMembershipIdException : MMSException
{
    public EmptyMembershipIdException() : base("Membership Id cannot be empty.")
    {
    }
}