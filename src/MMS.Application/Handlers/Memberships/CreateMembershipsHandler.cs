using System;
using System.Threading.Tasks;
using MMS.Application.Commands.Memberships;
using MMS.Domain.Consts;
using MMS.Domain.Contracts.Memberships;
using MMS.Domain.Entities.Memberships;
using MMS.Domain.Repositories.Memberships;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Handlers.Memberships;

internal sealed class CreateMembershipsHandler : ICommandHandler<CreateMemberships>
{
    private readonly IMembershipRepository _repository;

    public CreateMembershipsHandler(IMembershipRepository repository)
        => _repository = repository;

    public async Task HandleAsync(CreateMemberships command)
    {
        var membership = new Membership();
        var contract = new CreateMembershipContract
        {
            Id = Guid.NewGuid(),
            MembershipId = "command.MembershipId",
            FullName = command.FullName,
            EmiratesIdNumber = command.EmiratesIdNumber,
            EmiratesIdExpiry = command.EmiratesIdExpiry,
            EmiratesIdFrontPage = command.EmiratesIdFrontPage,
            EmiratesIdLastPage = command.EmiratesIdLastPage,
            DateOfBirth = command.DateOfBirth,
            MobileNumber = command.MobileNumber,
            AlternativeContactNumber = command.AlternativeContactNumber,
            Email = command.Email,
            PassportNumber = command.PassportNumber,
            PassportExpiry = command.PassportExpiry,
            ProfessionId = command.ProfessionId,
            QualificationId = command.QualificationId,
            BloodGroup = (BloodGroup)command.BloodGroup,
            HouseName = command.HouseName,
            AddressInIndia = command.AddressInIndia,
            PasswordHash = command.PasswordHash,
            AreaId = command.AreaId,
            MandalamId = command.MandalamId,
            IsMemberOfAnyIndianRegisteredOrganization = command.IsMemberOfAnyIndianRegisteredOrganization,
            IsKMCCWelfareScheme = command.IsKMCCWelfareScheme,
            CreatedAt = DateTime.UtcNow,
            CreatedBy = Guid.NewGuid()
        };
        membership.Create(contract);
        await _repository.AddAsync(membership);
    }
}