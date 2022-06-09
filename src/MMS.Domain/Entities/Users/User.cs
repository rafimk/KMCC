using System;
using MMS.Domain.Consts;
using MMS.Domain.Exceptions;
using MMS.Domain.ValueObjects;

namespace MMS.Domain.Entities.Users;

public class User
{
    public GenericId Id { get; private set; }
    public FullName FullName { get; private set; }
    public Email Email { get; private set; }
    public MobileNumber MobileNumber { get; private set; }
    public MobileNumber AlternativeContactNumber { get; private set; }
    public string PasswordHash { get; private set; }
    public UserRole Role { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public bool IsActive {get; private set;}
    public DateTime? VerifiedAt { get; private set; }

    private User()
    {
    }

    private User(GenericId id, FullName fullName, Email email, MobileNumber mobileNumber, 
        MobileNumber alternativeContactNumber, string passwordHash, DateTime createdAt, bool isActive)
    {
        Id = id;
        FullName = fullName;
        Email = email;
        MobileNumber = mobileNumber;
        AlternativeContactNumber = alternativeContactNumber;
        PasswordHash = passwordHash;
        CreatedAt = createdAt;
        IsActive = isActive;
    }

    public void Create(GenericId id, FullName fullName, Email email, MobileNumber mobileNumber, 
        MobileNumber contactNUmber, string passwordHash, DateTime createdAt)
    {
        Id = id;
        FullName = fullName;
        Email = email;
        MobileNumber = mobileNumber;
        AlternativeContactNumber = alternativeContactNumber;
        PasswordHash = passwordHash;
        CreatedAt = createdAt;
        IsActive = true;
    }

    public void Update(FullName fullName, Email email, MobileNumber mobileNumber, MobileNumber contactNUmber)
    {
        Id = id;
        FullName = fullName;
        Email = email;
        MobileNumber = mobileNumber;
        AlternativeContactNumber = alternativeContactNumber;
        CreatedAt = createdAt;
    }

    public void Activate()
    {
        IsActive = true;
    }

    public void Deactivate()
    {
        IsActive = false;
    }

    public void Verify(DateTime verifiedAt)
    {
        if (VerifiedAt.HasValue)
        {
            throw new UserAlreadyVerifiedException(Email);
        }

        VerifiedAt = verifiedAt;
    }
}