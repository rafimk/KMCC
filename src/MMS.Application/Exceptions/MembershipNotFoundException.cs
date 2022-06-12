using System;
using MMS.Shared.Abstractions.Exceptions;

namespace MMS.Application.Exceptions;

public class MembershipNotFoundException : MMSException
{
    public Guid Id { get; }
    
    public MembershipNotFoundException(Guid id) : base($"Membership Id {id} not found.")
    {
        Id = id;
    }
}