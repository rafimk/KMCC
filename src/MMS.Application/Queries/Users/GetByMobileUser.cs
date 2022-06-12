using MMS.Application.DTO.Users;
using MMS.Shared.Abstractions.Queries;

namespace MMS.Application.Queries.Users;

public class GetByMobileUser : IQuery<UserDto>
{
    public string mobileNumber { get; set; }
}