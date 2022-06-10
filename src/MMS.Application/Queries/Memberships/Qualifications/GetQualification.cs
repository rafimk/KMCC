using System;
using MMS.Application.DTO;
using MMS.Shared.Abstractions.Queries;

namespace MMS.Application.Memberships.Qualifications;

public class GetQualification : IQuery<QualificationDto>
{
    public Guid Id { get; set; }
}
