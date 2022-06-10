using System;
using MMS.Domain.ValueObjects;

namespace MMS.Application.DTO.Memberships.Professions;

public class ProfessionDto 
{
    public Guid Id { get; set; }
    public string Name{ get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedAt { get; set; }
}