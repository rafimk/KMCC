using System;
using MMS.Domain.Consts;
using MMS.Domain.Exceptions;
using MMS.Domain.ValueObjects;

namespace MMS.Domain.Entities.Users;

public class Membership
{
    public GenericId Id { get; private set; }
    public MembershipId MembershipId {get; private set;}
    public FullName FullName { get; private set; }
    public EmiratesIdNumber EmiratesIdNumber { get; private set;}
    public Date EmiratesIdExpiry {get; private set;}
    public Date DateOfBirth {get; private set;}
    public MobileNumber MobileNumber { get; private set; }
    public MobileNumber AlternativeContactNumber  { get; private set; }
    public Email Email { get; private set; }
    public PassportNumber PassportNumber {get; private set;}
    public Date PassportExpiry {get; private set;}
    public GenericId ProfessionId {get; private set;}
    public Profession Profession {get; private set;}
    public GenericId QualificationId {get; private set;}
    public Qualification Qualification {get; private set;}
    public BloodGroup BloodGroup {get; private set;}
    public string HouseName {get; private set;}
    public string AddressInIndia {get; private set;}
    public string PasswordHash { get; private set; }
    public GenericId AreaId {get; private set;}
    public Area Area {get; private set;}
    public GenericId MandalamId {get; private set;}
    public Mandalam Mandalam {get; private set;}
    public bool IsMemberOfAnyIndianRegisteredOrganization {get; private set;}
    public bool IsKMCCWelfareScheme {get; private set;}
    public double CollectedAmount {get;set;}
    public DateTime CreatedAt { get; private set; }
    public GenericId CreatedBy { get; private set; }
    public bool IsActive {get; private set;}
    public DateTime? VerifiedAt { get; private set; }

    private Membership()
    {
    }

    private Membership(GenericId id, MembershipId membershipId, FullName fullName, 
        EmiratesIdNumber emiratesIdNumber, Date emiratesIdExpiry, Date dateOfBirth, 
        MobileNumber mobileNumber, MobileNumber alternativeContactNumber, Email email, 
        PassportNumber passportNumber, Date passportExpiry, GenericId professionId,
        GenericId qualificationId, BloodGroup bloodGroup, string houseName, string addressInIndia,
        string passwordHash, GenericId areaId, GenericId mandalamId, 
        bool isMemberOfAnyIndianRegisteredOrganization, bool isKMCCWelfareScheme, DateTime createdAt, 
        GenericId createdBy, bool isActive)
    {
        Id = id;
        MembershipId = membershipId;
        FullName = fullName;
        EmiratesIdNumber = emiratesIdNumber;
        EmiratesIdExpiry = emiratesIdExpiry;
        DateOfBirth = dateOfBirth;
        MobileNumber = mobileNumber;
        AlternativeContactNumber = alternativeContactNumber;
        Email = email;
        PassportNumber = passportNumber;
        PassportExpiry = passportExpiry;
        ProfessionId = professionId;
        QualificationId = qualificationId;
        BloodGroup = bloodGroup;
        HouseName = houseName;
        AddressInIndia = addressInIndia;
        PasswordHash = passwordHash;
        AreaId = areaId;
        MandalamId = mandalamId;
        IsMemberOfAnyIndianRegisteredOrganization = isMemberOfAnyIndianRegisteredOrganization;
        IsKMCCWelfareScheme = isKMCCWelfareScheme;
        CreatedAt = createdAt;
        CreatedBy = CreatedBy;
        IsActive = isActive;
    }

    public void CreateMembership(GenericId id, MembershipId membershipId, FullName fullName, 
        EmiratesIdNumber emiratesIdNumber, Date emiratesIdExpiry, Date dateOfBirth, 
        MobileNumber mobileNumber, MobileNumber alternativeContactNumber, Email email, 
        PassportNumber passportNumber, Date passportExpiry, GenericId professionId,
        GenericId qualificationId, BloodGroup bloodGroup, string houseName, string addressInIndia,
        string passwordHash, GenericId areaId, GenericId mandalamId, 
        bool isMemberOfAnyIndianRegisteredOrganization, bool isKMCCWelfareScheme, DateTime createdAt, GenericId createdBy)
    {
         Id = id;
        MembershipId = membershipId;
        FullName = fullName;
        EmiratesIdNumber = emiratesIdNumber;
        EmiratesIdExpiry = emiratesIdExpiry;
        DateOfBirth = dateOfBirth;
        MobileNumber = mobileNumber;
        AlternativeContactNumber = alternativeContactNumber;
        Email = email;
        PassportNumber = passportNumber;
        PassportExpiry = passportExpiry;
        ProfessionId = professionId;
        QualificationId = qualificationId;
        BloodGroup = bloodGroup;
        HouseName = houseName;
        AddressInIndia = addressInIndia;
        PasswordHash = passwordHash;
        AreaId = areaId;
        MandalamId = mandalamId;
        IsMemberOfAnyIndianRegisteredOrganization = isMemberOfAnyIndianRegisteredOrganization;
        IsKMCCWelfareScheme = isKMCCWelfareScheme;
        CreatedAt = createdAt;
        CreatedBy = CreatedBy;
        IsActive = true;
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