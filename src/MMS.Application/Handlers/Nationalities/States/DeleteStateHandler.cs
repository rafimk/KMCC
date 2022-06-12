using System.Threading.Tasks;
using MMS.Application.Commands.Nationalities.States;
using MMS.Application.Exceptions;
using MMS.Domain.Repositories.Nationalities;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Handlers.Nationalities.States;

internal sealed class DeleteStateHandler : ICommandHandler<DeleteState>
{
    private readonly IStateRepository _repository;

    public DeleteStateHandler(IStateRepository repository)
        => _repository = repository;

    public async Task HandleAsync(DeleteState command)
    {
        var state = await _repository.GetByIdAsync(command.Id);

        if (state is null)
        {
            throw new StateNotFoundException(command.Id);
        }
        state.Delete();
        await _repository.UpdateAsync(state);
    }
}