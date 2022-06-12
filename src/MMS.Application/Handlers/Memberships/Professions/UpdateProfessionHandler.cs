using System.Threading.Tasks;
using MMS.Application.Commands.Memberships.Professions;
using MMS.Application.Exceptions;
using MMS.Domain.Repositories.Memberships.Professions;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Handlers.Memberships.Professions;

internal sealed class UpdateProfessionHandler : ICommandHandler<UpdateProfession>
{
    private readonly IProfessionRepository _repository;

    public UpdateProfessionHandler(IProfessionRepository repository)
        => _repository = repository;

    public async Task HandleAsync(UpdateProfession command)
    {
        var profession = await _repository.GetByIdAsync(command.Id);

        if (profession is null)
        {
            throw new ProfessionNotFoundException(command.Id);
        }
        profession.Update(command.Name);
        await _repository.UpdateAsync(profession);
    }
}