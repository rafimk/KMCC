using System;
using System.Threading.Tasks;
using MMS.Application.Commands.Nationalities.States;
using MMS.Domain.Entities.Nationalities;
using MMS.Domain.Repositories.Nationalities;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Handlers.Nationalities.States;

internal sealed class CreateStateHandler : ICommandHandler<CreateState>
{
    private readonly IStateRepository _repository;

    public CreateStateHandler(IStateRepository repository)
        => _repository = repository;

    public async Task HandleAsync(CreateState command)
    {
        var state = new State();
        state.Create(Guid.NewGuid(), command.Name, DateTime.UtcNow);
        await _repository.AddAsync(state);
    }
}