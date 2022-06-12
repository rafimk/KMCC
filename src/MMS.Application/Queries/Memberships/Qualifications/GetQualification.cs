using System;
using MMS.Application.DTO.Memberships.Qualifications;
using MMS.Shared.Abstractions.Queries;

namespace MMS.Application.Queries.Memberships.Qualifications;

public class GetQualification : IQuery<QualificationDto>
{
    public Guid Id { get; set; }
}
