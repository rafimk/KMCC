using System.Collections.Generic;
using MMS.Application.DTO.Users;
using MMS.Shared.Abstractions.Queries;

namespace MMS.Application.Queries.Users;

public class GetAllUsers : IQuery<IEnumerable<UserDto>>
{

}