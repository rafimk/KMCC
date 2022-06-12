using System;
using MMS.Application.DTO.Memberships.Professions;
using MMS.Shared.Abstractions.Queries;

namespace MMS.Application.Queries.Memberships.Professions;

public class GetProfession : IQuery<ProfessionDto>
{
    public Guid Id { get; set; }
}
