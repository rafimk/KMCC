using System;
using System.Collections.Generic;
using MMS.Application.DTO.Nationalities.Panchayaths;
using MMS.Shared.Abstractions.Queries;

namespace MMS.Application.Queries.Nationalities.Panchayats;

public class GetByMandalamPanchayats : IQuery<IEnumerable<PanchayatDto>>
{
    public Guid MandalamId { get; set; }
}