using System.Threading.Tasks;
using MMS.Application.Commands.Memberships.Professions;
using MMS.Application.Exceptions;
using MMS.Domain.Repositories.Memberships.Professions;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Handlers.Memberships.Professions;

internal sealed class DeleteProfessionHandler : ICommandHandler<DeleteProfession>
{
    private readonly IProfessionRepository _repository;

    public DeleteProfessionHandler(IProfessionRepository repository)
        => _repository = repository;

    public async Task HandleAsync(DeleteProfession command)
    {
        var profession = await _repository.GetByIdAsync(command.Id);

        if (profession is null)
        {
            throw new ProfessionNotFoundException(command.Id);
        }
        profession.Delete();
        await _repository.UpdateAsync(profession);
    }
}