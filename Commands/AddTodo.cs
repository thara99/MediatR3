using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR3.Database;
using MediatR3.Queries;
using MediatR3.Domain;

namespace MediatR3.Commands
{
    public static class AddTodo
    {

        public record Command(String Name) : IRequest<int>;

        public class Handler : IRequestHandler<Command, int>
        {
            private readonly Repository repository;

            public Handler(Repository repository)
            {
                this.repository = repository;
            }
            public async Task<int> Handle(Command request, CancellationToken cancellationToken)
            {
                repository.Todos.Add(new Todo { Id = 10, Name = request.Name });
                return 10;
            }
        }

    }
}
