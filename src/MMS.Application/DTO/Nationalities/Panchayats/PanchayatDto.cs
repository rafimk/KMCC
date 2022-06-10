using System;
using MMS.Domain.Consts;
using MMS.Domain.ValueObjects;

namespace MMS.Application.DTO.Nationalities.Panchayaths;

public class PanchayatDto
{
    public Guid Id { get; private set; }
    public string Name{ get; private set; }
    public Guid MandalamId { get; private set; }
    public string MandalamName { get; private set; }
    public int Type { get; private set; }
    public bool IsDeleted { get; private set; }
    public DateTime CreatedAt { get; private set; }
}