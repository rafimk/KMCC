using System;
using MMS.Shared.Abstractions.Exceptions;

namespace MMS.Application.Exceptions;

public class MembershipPeriodNotFoundException : MMSException
{
    public Guid Id { get; }
    
    public MembershipPeriodNotFoundException(Guid id) : base($"Membership period Id {id} not found.")
    {
        Id = id;
    }
}