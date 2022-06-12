using System.Threading.Tasks;
using MMS.Application.Commands.Nationalities.States;
using MMS.Application.Exceptions;
using MMS.Domain.Repositories.Nationalities;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Handlers.Nationalities.States;

internal sealed class UpdateStateHandler : ICommandHandler<UpdateState>
{
    private readonly IStateRepository _repository;

    public UpdateStateHandler(IStateRepository repository)
        => _repository = repository;

    public async Task HandleAsync(UpdateState command)
    {
        var state = await _repository.GetByIdAsync(command.Id);

        if (state is null)
        {
            throw new StateNotFoundException(command.Id);
        }
        state.Update(command.Name);
        await _repository.UpdateAsync(state);
    }
}