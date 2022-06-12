using System.Threading.Tasks;
using MMS.Application.Commands.Users;
using MMS.Application.Exceptions;
using MMS.Domain.Contracts.Users;
using MMS.Domain.Repositories.Users;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Handlers.Users;

internal sealed class UpdateUserHandler : ICommandHandler<UpdateUser>
{
    private readonly IUserRepository _repository;

    public UpdateUserHandler(IUserRepository repository)
        => _repository = repository;

    public async Task HandleAsync(UpdateUser command)
    {
        var user = await _repository.GetByIdAsync(command.Id);

        if (user is null)
        {
            throw new UserNotFoundException(command.Id);
        }

        var contract = new UpdateCreateContract
        {
            FullName = command.FullName,
            Email = command.Email,
            MobileNumber = command.MobileNumber,
            AlternativeContactNumber = command.AlternativeContactNumber
        };
        
        user.Update(contract);
        await _repository.UpdateAsync(user);
    }
}