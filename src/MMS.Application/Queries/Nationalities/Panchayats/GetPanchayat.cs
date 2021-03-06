using System;
using MMS.Application.DTO;
using MMS.Application.DTO.Nationalities.Panchayaths;
using MMS.Shared.Abstractions.Queries;

namespace MMS.Application.Queries.Nationalities.Panchayats;

public class GetPanchayat : IQuery<PanchayatDto>
{
    public Guid Id { get; set; }
}
