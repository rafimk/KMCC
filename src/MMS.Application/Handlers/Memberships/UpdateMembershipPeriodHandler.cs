using System.Threading.Tasks;
using MMS.Application.Commands.Memberships;
using MMS.Application.Exceptions;
using MMS.Domain.Repositories.Memberships;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Handlers.Memberships;

internal sealed class UpdateMembershipPeriodHandler : ICommandHandler<UpdateMembershipPeriod>
{
    private readonly IMembershipPeriodRepository _repository;

    public UpdateMembershipPeriodHandler(IMembershipPeriodRepository repository)
        => _repository = repository;

    public async Task HandleAsync(UpdateMembershipPeriod command)
    {
        var membershipPeriod = await _repository.GetByIdAsync(command.Id);

        if (membershipPeriod is null)
        {
            throw new MembershipPeriodNotFoundException(command.Id);
        }
        membershipPeriod.Update(command.Start, command.End, command.RegistrationUntil);
        await _repository.UpdateAsync(membershipPeriod);
    }
}