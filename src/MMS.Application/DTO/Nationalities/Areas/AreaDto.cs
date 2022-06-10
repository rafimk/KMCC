using System;
using MMS.Domain.ValueObjects;

namespace MMS.Application.DTO.Nationalities.Areas;

public class AreaDto
{
    public Guid Id { get; set; }
    public string Name{ get; set; }
    public Guid StateId { get; set; }
    public string StateName { get; set; }
    public string Prefix { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedAt { get; set; }
}