using System.Threading.Tasks;
using MMS.Application.Commands.Memberships.Qualifications;
using MMS.Application.Exceptions;
using MMS.Domain.Repositories.Memberships.Qualifications;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Handlers.Memberships.Qualifications;

internal sealed class UpdateQualificationHandler : ICommandHandler<UpdateQualification>
{
    private readonly IQualificationRepository _repository;

    public UpdateQualificationHandler(IQualificationRepository repository)
        => _repository = repository;

    public async Task HandleAsync(UpdateQualification command)
    {
        var qualification = await _repository.GetByIdAsync(command.Id);

        if (qualification is null)
        {
            throw new QualificationNotFoundException(command.Id);
        }
        qualification.Update(command.Name);
        await _repository.UpdateAsync(qualification);
    }
}