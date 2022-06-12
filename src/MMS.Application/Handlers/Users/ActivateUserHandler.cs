using System.Threading.Tasks;
using MMS.Application.Commands.Users;
using MMS.Application.Exceptions;
using MMS.Domain.Repositories.Users;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Handlers.Users;

internal sealed class ActivateUserHandler : ICommandHandler<ActivateUser>
{
    private readonly IUserRepository _repository;

    public ActivateUserHandler(IUserRepository repository)
        => _repository = repository;

    public async Task HandleAsync(ActivateUser command)
    {
        var user = await _repository.GetByIdAsync(command.Id);

        if (user is null)
        {
            throw new UserNotFoundException(command.Id);
        }
 
        await _repository.Activate(command.Id);
    }
}
