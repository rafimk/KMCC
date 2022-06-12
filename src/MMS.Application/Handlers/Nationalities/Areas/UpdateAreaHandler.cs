using System.Threading.Tasks;
using MMS.Application.Commands.Nationalities.Areas;
using MMS.Application.Exceptions;
using MMS.Domain.Repositories.Nationalities;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Handlers.Nationalities.Areas;

internal sealed class UpdateAreaHandler : ICommandHandler<UpdateArea>
{
    private readonly IAreaRepository _repository;

    public UpdateAreaHandler(IAreaRepository repository)
        => _repository = repository;

    public async Task HandleAsync(UpdateArea command)
    {
        var area = await _repository.GetByIdAsync(command.Id);

        if (area is null)
        {
            throw new AreaNotFoundException(command.Id);
        }
        area.Update(command.Name, command.StateId);
        await _repository.UpdateAsync(area);
    }
}