using System;
using MMS.Application.DTO;
using MMS.Shared.Abstractions.Queries;

namespace MMS.Application.Queries.Nationalities.Mandalams;

public class GetByMandalamPanchayats : IQuery<IEnumerable<PanchayatDto>>
{
    public Guid MandalamId { get; set; }
}