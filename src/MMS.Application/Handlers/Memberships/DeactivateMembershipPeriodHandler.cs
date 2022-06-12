using System.Threading.Tasks;
using MMS.Application.Commands.Memberships;
using MMS.Application.Exceptions;
using MMS.Domain.Repositories.Memberships;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Handlers.Memberships;

internal sealed class DeactivateMembershipPeriodHandler : ICommandHandler<DeactivateMembershipPeriod>
{
    private readonly IMembershipPeriodRepository _repository;

    public DeactivateMembershipPeriodHandler(IMembershipPeriodRepository repository)
        => _repository = repository;

    public async Task HandleAsync(DeactivateMembershipPeriod command)
    {
        var membershipPeriod = await _repository.GetByIdAsync(command.Id);

        if (membershipPeriod is null)
        {
            throw new MembershipPeriodNotFoundException(command.Id);
        }
        membershipPeriod.Deactivate();
        membershipPeriod.Update(membershipPeriod.Start, membershipPeriod.End, membershipPeriod.RegistrationUntil);
        await _repository.UpdateAsync(membershipPeriod);
    }
}