using System;
using MMS.Application.DTO.Users;
using MMS.Shared.Abstractions.Queries;

namespace MMS.Application.Queries.Users;

public class GetUser : IQuery<UserDto>
{
    public Guid Id { get; set; }
}
