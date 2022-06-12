using System.Threading.Tasks;
using MMS.Application.Commands.Users;
using MMS.Application.Exceptions;
using MMS.Domain.Repositories.Users;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Handlers.Users;

internal sealed class DeactivateUserHandler : ICommandHandler<DeactivateUser>
{
    private readonly IUserRepository _repository;

    public DeactivateUserHandler(IUserRepository repository)
        => _repository = repository;

    public async Task HandleAsync(DeactivateUser command)
    {
        var user = await _repository.GetByIdAsync(command.Id);

        if (user is null)
        {
            throw new UserNotFoundException(command.Id);
        }
 
        await _repository.Deactivate(command.Id);
    }
}