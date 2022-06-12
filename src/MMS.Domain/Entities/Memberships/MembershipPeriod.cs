using System;
using MMS.Domain.ValueObjects;

namespace MMS.Domain.Entities.Memberships;

public class MembershipPeriod 
{
    public GenericId Id { get; private set; }
    public Date Start { get; private set; }
    public Date End {get; private set;}
    public Date RegistrationUntil { get; private set; }
    public bool IsActive { get; private set; }
    public DateTime CreatedAt { get; private set; }

    private MembershipPeriod(GenericId id, Date start, Date end, Date registrationUntil, 
        bool isActive, DateTime createdAt)
    {
        Id = id;
        Start = start;
        End = end;
        RegistrationUntil = registrationUntil;
        IsActive = isActive;
        CreatedAt = createdAt;
    }

    public MembershipPeriod()
    {
    }

    public void Create(GenericId id, Date start, Date end, Date registrationUntil, DateTime createdAt)
    {
        Id = id;
        Start = start;
        End = end;
        RegistrationUntil = registrationUntil;
        IsActive = true;
        CreatedAt = createdAt;
    }
    
    public void Update(Date start, Date end, Date registrationUntil)
    {
        Start = start;
        End = end;
        RegistrationUntil = registrationUntil;
    }
    
    public void Activate()
    {
        IsActive = true;
    }

    public void Deactivate()
    {
        IsActive = false;
    }
}