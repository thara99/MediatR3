using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR3.Domain;
namespace MediatR3.Database
{
    public class Repository
    {

        public List<Todo> Todos { get; } = new List<Todo>
        {
            new Todo{Id = 1, Name = "Take a Bed tea", Completed = true},
            new Todo{Id = 2, Name = "Get a breakfast", Completed = true},
            new Todo{Id = 3, Name = "Wash a car", Completed = false},
            new Todo{Id = 4, Name = "Get a lunch", Completed = false}

        };

    }
}
