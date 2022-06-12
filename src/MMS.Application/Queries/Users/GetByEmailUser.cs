using MMS.Application.DTO.Users;
using MMS.Shared.Abstractions.Queries;

namespace MMS.Application.Queries.Users;

public class GetByEmailUser : IQuery<UserDto>
{
    public string email { get; set; }
}