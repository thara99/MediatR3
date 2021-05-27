using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR3.Queries;

namespace MediatR3.Controllers
{
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly IMediator mediator;

        public TodoController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("/{id}"]
        public async Task<IActionResult> GetTodoById(int id)
        {
            var response = await mediator.Send(new GetTodoById.Query(id));
            return response == null ? NotFound() : Ok(response);
        }
    }
}
