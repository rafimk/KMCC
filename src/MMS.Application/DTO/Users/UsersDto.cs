using System;
using MMS.Domain.Consts;
using MMS.Domain.Exceptions;
using MMS.Domain.ValueObjects;

namespace MMS.Application.DTO.Users;

public class UsersDto
{
    public Guid Id { get; private set; }
    public string FullName { get; private set; }
    public string Email { get; private set; }
    public string MobileNumber { get; private set; }
    public string AlternativeContactNumber { get; private set; }
    public int Role { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public bool IsActive {get; private set;}
    public DateTime? VerifiedAt { get; private set; }
}