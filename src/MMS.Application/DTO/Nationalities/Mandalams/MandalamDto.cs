using System;
using MMS.Domain.ValueObjects;

namespace MMS.Application.DTO.Nationalities.Mandalams;

public class MandalamDto
{
    public Guid Id { get; set; }
    public string Name{ get; set; }
    public Guid DistrictId { get; set; }
    public string DistrictName{ get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedAt { get; set; }
}