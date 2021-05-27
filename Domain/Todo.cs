using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatR3.Domain
{
    public class Todo
    {

        public int Id { get; set; }
        public String Name { get; set; }
        public bool Completed { get; set; }


    }
}
