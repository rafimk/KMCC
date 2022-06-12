using System;
using MMS.Domain.ValueObjects;

namespace MMS.Domain.DomainServices;

public interface IUserCreationService
{
    void CreateUser(GenericId id, FullName fullName, Email email, MobileNumber mobileNumber, 
        MobileNumber alternativeContactNumber, string passwordHash, DateTime createdAt);
}