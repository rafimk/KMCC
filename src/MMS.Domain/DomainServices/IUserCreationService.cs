
using MMS.Domain.Entities;
using MMS.Domain.ValueObjects;

namespace MMS.Domain.DomainServices;

public interface IUserCreationService
{
    void CreateUser(GenericId id, FullName fullName, Email email, MobileNumber mobileNumber, 
        MobileNumber contactNUmber, string passwordHash, DateTime createdAt);
}