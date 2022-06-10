using System;
using MMS.Application.DTO;
using MMS.Shared.Abstractions.Queries;

namespace MMS.Application.Queries.Users;

public class GetByEmailUser : IQuery<UserDto>
{
    public string email { get; set; }
}