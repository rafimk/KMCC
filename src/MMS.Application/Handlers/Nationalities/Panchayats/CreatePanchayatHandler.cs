using System;
using System.Threading.Tasks;
using MMS.Application.Commands.Nationalities.Panchayats;
using MMS.Domain.Consts;
using MMS.Domain.Entities.Nationalities;
using MMS.Domain.Repositories.Nationalities;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Handlers.Nationalities.Panchayats;

internal sealed class CreatePanchayatHandler : ICommandHandler<CreatePanchayat>
{
    private readonly IPanchayatRepository _repository;

    public CreatePanchayatHandler(IPanchayatRepository repository)
        => _repository = repository;

    public async Task HandleAsync(CreatePanchayat command)
    {
        var panchayat = new Panchayat();
        panchayat.Create(Guid.NewGuid(), command.Name, command.MandalamId, (PanchayatType)command.Type, DateTime.UtcNow);
        await _repository.AddAsync(panchayat);
    }
}