using System;
using MMS.Application.DTO;
using MMS.Shared.Abstractions.Queries;

namespace MMS.Application.Memberships.Professions;

public class GetProfession : IQuery<ProfessionDto>
{
    public Guid Id { get; set; }
}
