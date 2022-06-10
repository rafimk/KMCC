using System;
using MMS.Application.DTO;
using MMS.Shared.Abstractions.Queries;

namespace MMS.Application.Queries.Users;

public class GetByMobileUser : IQuery<UserDto>
{
    public string mobileNumber { get; set; }
}