using MMS.Domain.Exceptions;

namespace MMS.Domain.ValueObjects;

public record MembershipId
{
    public string Value { get; }

    public MembershipId(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new EmptyMembershipIdException();
        }
        
        Value = value;
    }

    public static implicit operator string(MembershipId membershipId)
        => membershipId.Value;
    
    public static implicit operator MembershipId(string membershipId)
        => new(membershipId);
}