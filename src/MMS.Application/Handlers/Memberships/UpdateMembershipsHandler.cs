using System;
using System.Threading.Tasks;
using MMS.Application.Commands.Memberships;
using MMS.Application.Exceptions;
using MMS.Domain.Consts;
using MMS.Domain.Contracts.Memberships;
using MMS.Domain.Repositories.Memberships;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Handlers.Memberships;

internal sealed class UpdateMembershipsHandler : ICommandHandler<UpdateMemberships>
{
    private readonly IMembershipRepository _repository;

    public UpdateMembershipsHandler(IMembershipRepository repository)
        => _repository = repository;

    public async Task HandleAsync(UpdateMemberships command)
    {
        var membership = await _repository.GetByIdAsync(command.Id);

        if (membership is null)
        {
            throw new MembershipNotFoundException(command.Id);
        }
        
        var contract = new UpdateMembershipContract
        {
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
            IsMemberOfAnyIndianRegisteredOrganization = command.IsMemberOfAnyIndianRegisteredOrganization,
            IsKMCCWelfareScheme = command.IsKMCCWelfareScheme,
            CreatedAt = DateTime.UtcNow,
            CreatedBy = Guid.NewGuid()
        };
        membership.Update(contract);
        await _repository.UpdateAsync(membership);
    }
}