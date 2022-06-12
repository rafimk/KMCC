using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MMS.Application.Commands.Nationalities.States;
using MMS.Application.DTO.Nationalities.States;
using MMS.Application.Queries.Nationalities.States;
using MMS.Shared.Abstractions.Commands;
using MMS.Shared.Abstractions.Queries;

namespace MMS.Api.Controllers;

 public class StateController : BaseController
    {
        private readonly ICommandDispatcher _commandDispatcher;
        private readonly IQueryDispatcher _queryDispatcher;

        public StateController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher)
        {
            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<StateDto>> Get([FromRoute] GetById query)
        {
            var result = await _queryDispatcher.QueryAsync(query);
            return OkOrNotFound(result);
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StateDto>>> Get([FromQuery] GetStates query)
        {
            var result = await _queryDispatcher.QueryAsync(query);
            return OkOrNotFound(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateState command)
        {
            await _commandDispatcher.DispatchAsync(command);
            return CreatedAtAction(nameof(Get), new {id = command.Id}, null);
        }
        
        [HttpPut("{Id:guid}")]
        public async Task<IActionResult> Put([FromBody] UpdateState command)
        {
            await _commandDispatcher.DispatchAsync(command);
            return Ok();
        }
        
        [HttpDelete("{Id:guid}")]
        public async Task<IActionResult> Delete([FromBody] DeleteState command)
        {
            await _commandDispatcher.DispatchAsync(command);
            return Ok();
        }
        
    }