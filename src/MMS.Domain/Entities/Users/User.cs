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
    public MobileNumber ContactNUmber { get; private set; }
    public string PasswordHash { get; private set; }
    public UserRole Role { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime? VerifiedAt { get; private set; }

    private User()
    {
    }

    public User(GenericId id, FullName fullName, Email email, MobileNumber mobileNumber, 
        MobileNumber contactNUmber, string passwordHash, DateTime createdAt)
    {
        Id = id;
        FullName = fullName;
        Email = email;
        MobileNumber = mobileNumber;
        ContactNUmber = contactNUmber;
        PasswordHash = passwordHash;
        CreatedAt = createdAt;
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