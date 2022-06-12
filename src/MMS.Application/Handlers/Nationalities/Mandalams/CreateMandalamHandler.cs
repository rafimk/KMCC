using System;
using System.Threading.Tasks;
using MMS.Application.Commands.Nationalities.Mandalams;
using MMS.Domain.Entities.Nationalities;
using MMS.Domain.Repositories.Nationalities;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Handlers.Nationalities.Mandalams;

internal sealed class CreateMandalamHandler : ICommandHandler<CreateMandalam>
{
    private readonly IMandalamRepository _repository;

    public CreateMandalamHandler(IMandalamRepository repository)
        => _repository = repository;

    public async Task HandleAsync(CreateMandalam command)
    {
        var mandalam = new Mandalam();
        mandalam.Create(Guid.NewGuid(), command.Name, command.DistrictId, DateTime.UtcNow);
        await _repository.AddAsync(mandalam);
    }
}