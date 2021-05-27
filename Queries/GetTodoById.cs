using MediatR;
using MediatR3.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR3.Queries
{
    public class GetTodoById
    {

        //query
        public record Query(int Id) : IRequest<Response>;


        //handler
        public class Handler : IRequestHandler<Query, Response>
        {
            private readonly Repository repository;
            public Handler (Repository repository)
            {
                this.repository = repository;
            }
            public async Task<Response> Handle(Query request, CancellationToken cancellationToken)
            {

                var todo = repository.Todos.FirstOrDefault(x => x.Id == request.Id);
                return todo == null ? null : new Response(todo.Id, todo.Name, todo.Completed);
            }
        }

        //response
        public record Response(int Id, String Name, bool Completed);
    }
}
