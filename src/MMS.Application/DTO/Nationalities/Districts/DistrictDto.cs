using System;
using MMS.Domain.ValueObjects;

namespace MMS.Application.DTO.Nationalities.Districts;

public class DistrictDto
{
    public Guid Id { get; set; }
    public string Name{ get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedAt { get; set; }
}