using MMS.Domain.Entities;
using MMS.Domain.ValueObjects;
using MMS.Shared.Abstractions.Domain;

namespace MMS.Domain.Events.Users
{
    public record MembershipCreated() : IDomainEvent
    {
        public GenericId Id { get; set; }
        public MembershipId MembershipId {get; set;}
        public FullName FullName { get; set; }
        public EmiratesIdNumber EmiratesIdNumber { get; set;}
        public Date EmiratesIdExpiry {get; set;}
        public Date DateOfBirth {get; set;}
        public MobileNumber MobileNumber { get; set; }
        public MobileNumber AlternativeContactNumber { get; set; }
        public Email Email { get; set; }
        public PassportNumber PassportNumber {get; set;}
        public Date PassportExpiry {get; set;}
        public GenericId ProfessionId {get; et;}
        public Profession Profession {get; set;}
        public GenericId QualificationId {get; set};
        public Qualification Qualification {get; set;}
        public BloodGroup BloodGroup {get; set;}
        public string HouseName {get; set;}
        public string AddressInIndia {get; set;}
        public string PasswordHash { get; set; }
        public GenericId AreaId {get; set;}
        public Area Area {get; set;}
        public GenericId MandalamId {get; set;}
        public Mandalam Mandalam {get; set;}
        public bool IsMemberOfAnyIndianReisteredOrganization {get; set;}
        public bool IsKMCCWelfareScheme {get; set;}
        public double CollectedAmount {get;set;}
    }
}