using System;
using MMS.Domain.Consts;
using MMS.Domain.Contracts.Users;
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

    public User()
    {
    }

    private User(UserContract contract)
    {
        Id = contract.Id;
        FullName = contract.FullName;
        Email = contract.Email;
        MobileNumber = contract.MobileNumber;
        AlternativeContactNumber = contract.AlternativeContactNumber;
        PasswordHash = contract.PasswordHash;
        CreatedAt = contract.CreatedAt;
        IsActive = contract.IsActive;
    }

    public void Create(UserCreateContract contract)
    {
        Id = contract.Id;
        FullName = contract.FullName;
        Email = contract.Email;
        MobileNumber = contract.MobileNumber;
        AlternativeContactNumber = contract.AlternativeContactNumber;
        PasswordHash = contract.PasswordHash;
        CreatedAt = contract.CreatedAt;
        IsActive = true;
    }

    public void Update(UpdateCreateContract contract)
    {
        FullName = contract.FullName;
        Email = contract.Email;
        MobileNumber = contract.MobileNumber;
        AlternativeContactNumber = contract.AlternativeContactNumber;
    }
    
    public void ChangePassword(string newPasswordHash)
    {
        PasswordHash = newPasswordHash;
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