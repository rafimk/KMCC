using System;
using MMS.Domain.ValueObjects;

namespace MMS.Domain.Entities.Nationalities;

public class MembershipPeriod 
{
    public GenericId Id { get; private set; }
    public Date Start { get; private set; }
    public Date End {get; private set;}
    public Date RegistrationUntil { get; private set; }
    public bool IsActive { get; private set; }
    public DateTime CreatedAt { get; private set; }

    private MembershipPeriod(GenericId id, Date start, Date end, Date RegistrationUntil, 
        bool isActive, DateTime createdAt)
    {
        Id = id;
        Start = start;
        End = end;
        RegistrationUntil = registrationUntil;
        IsActive = isActive;
        CreatedAt = createdAt;
    }

    private MembershipPeriod()
    {
    }

    public void Create(GenericId id, Date start, Date end, Date RegistrationUntil, bool isActive, DateTime createdAt)
    {
        Id = id;
        Start = start;
        End = end;
        RegistrationUntil = registrationUntil;
        IsActive = true;
        CreatedAt = createdAt;
    }
    
    public void Update(Date start, Date end, Date RegistrationUntil)
    {
        Start = start;
        End = end;
        RegistrationUntil = registrationUntil;
    }
    
    public void  InActive()
    {
        IsActive = false;
    }
}