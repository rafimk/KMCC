using System;
using System.Threading.Tasks;
using MMS.Application.Commands.Memberships.Professions;
using MMS.Domain.Entities.Memberships.Professions;
using MMS.Domain.Repositories.Memberships.Professions;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Handlers.Memberships.Professions;

internal sealed class CreateProfessionHandler : ICommandHandler<CreateProfession>
{
    private readonly IProfessionRepository _repository;

    public CreateProfessionHandler(IProfessionRepository repository)
        => _repository = repository;

    public async Task HandleAsync(CreateProfession command)
    {
        var profession = new Profession();
        profession.Create(Guid.NewGuid(), command.Name, DateTime.UtcNow);
        await _repository.AddAsync(profession);
    }
}