using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Activities
{
    public class Create
    {
        public class Command : IRequest<Activity>
        {
            public Activity Activity { get; set; }
        }
        public class Handler : IRequestHandler<Command,Activity>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Activity> Handle(Command request, CancellationToken cancellationToken)
            {

                _context.Activities.AddRange(request.Activity);
                await _context.SaveChangesAsync(cancellationToken);

                return request.Activity;
            }
        }
    }
}