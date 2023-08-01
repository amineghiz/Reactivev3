using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Halls
{
    public class Create
    {
        public class Command : IRequest<Hall>
        {
            public Hall Hall { get; set; }
        }
        public class Handler : IRequestHandler<Command, Hall>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Hall> Handle(Command request, CancellationToken cancellationToken)
            {
                _context.Halls.AddRange(request.Hall);

                await _context.SaveChangesAsync(cancellationToken);
                return request.Hall;
            }
        }
    }
}