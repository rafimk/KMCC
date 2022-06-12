using MMS.Domain.ValueObjects;

namespace MMS.Domain.Contracts.Users;

public record UpdateCreateContract()
{
    public FullName FullName { get; set; }
    public Email Email { get; set; }
    public MobileNumber MobileNumber { get; set; } 
    public MobileNumber AlternativeContactNumber { get; set; }
}