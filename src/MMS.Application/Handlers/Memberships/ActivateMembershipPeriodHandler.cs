using System.Threading.Tasks;
using MMS.Application.Commands.Memberships;
using MMS.Application.Exceptions;
using MMS.Domain.Repositories.Memberships;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Handlers.Memberships;

internal sealed class ActivateMembershipPeriodHandler : ICommandHandler<ActivateMembershipPeriod>
{
    private readonly IMembershipPeriodRepository _repository;

    public ActivateMembershipPeriodHandler(IMembershipPeriodRepository repository)
        => _repository = repository;

    public async Task HandleAsync(ActivateMembershipPeriod command)
    {
        var membershipPeriod = await _repository.GetByIdAsync(command.Id);

        if (membershipPeriod is null)
        {
            throw new MembershipPeriodNotFoundException(command.Id);
        }
        membershipPeriod.Activate();
        membershipPeriod.Update(membershipPeriod.Start, membershipPeriod.End, membershipPeriod.RegistrationUntil);
        await _repository.UpdateAsync(membershipPeriod);
    }
}