using System;
using MMS.Domain.Consts;
using MMS.Domain.Exceptions;
using MMS.Domain.ValueObjects;

namespace MMS.Application.DTO.Memberships;

public class MembershipDto
{
    public Guid Id { get; private set; }
    public Guid MembershipId {get; private set;}
    public string FullName { get; private set; }
    public string EmiratesIdNumber { get; private set;}
    public DateTime EmiratesIdExpiry {get; private set;}
    public DateTime DateOfBirth {get; private set;}
    public string MobileNumber { get; private set; }
    public string AlternativeContactNumber  { get; private set; }
    public string Email { get; private set; }
    public string PassportNumber {get; private set;}
    public DateTime PassportExpiry {get; private set;}
    public Guid ProfessionId {get; private set;}
    public string ProfessionName {get; private set;}
    public Guid QualificationId {get; private set;}
    public string QualificationName {get; private set;}
    public string BloodGroup {get; private set;}
    public string HouseName {get; private set;}
    public string AddressInIndia {get; private set;}
    public string PasswordHash { get; private set; }
    public Guid AreaId {get; private set;}
    public string AreaName {get; private set;}
     public string StateName {get; private set;}
    public Guid MandalamId {get; private set;}
    public string MandalamName {get; private set;}
    public string DistrictName {get; private set;}
    public bool IsMemberOfAnyIndianRegisteredOrganization {get; private set;}
    public bool IsKMCCWelfareScheme {get; private set;}
    public double CollectedAmount {get;set;}
    public DateTime CreatedAt { get; private set; }
    public Guid CreatedBy { get; private set; }
    public bool IsActive {get; private set;}
    public DateTime? VerifiedAt { get; private set; }
}
