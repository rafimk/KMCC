using System;
using System.Threading.Tasks;
using MMS.Application.Commands.Memberships;
using MMS.Domain.Entities.Memberships;
using MMS.Domain.Repositories.Memberships;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Handlers.Memberships;

internal sealed class CreateMembershipPeriodHandler : ICommandHandler<CreateMembershipPeriod>
{
    private readonly IMembershipPeriodRepository _repository;

    public CreateMembershipPeriodHandler(IMembershipPeriodRepository repository)
        => _repository = repository;

    public async Task HandleAsync(CreateMembershipPeriod command)
    {
        var membershipPeriod = new MembershipPeriod();
        
        membershipPeriod.Create(Guid.NewGuid(), command.Start , command.End, command.RegistrationUntil, DateTime.UtcNow);
        await _repository.AddAsync(membershipPeriod);
    }
}