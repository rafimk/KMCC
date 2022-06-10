using System;
using MMS.Application.DTO;
using MMS.Shared.Abstractions.Queries;

namespace MMS.Application.Queries.Nationalities.Districts;

public class GetDistrict : IQuery<DistrictDto>
{
    public Guid Id { get; set; }
}
