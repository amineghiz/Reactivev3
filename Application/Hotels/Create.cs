using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Hotels
{
    public class Create
    {
        public class Command : IRequest<Hotel>
        {
            public Hotel Hotel { get; set; }
        }
        public class Handler : IRequestHandler<Command, Hotel>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Hotel> Handle(Command request, CancellationToken cancellationToken)
            {
                _context.Hotels.AddRange(request.Hotel);

                await _context.SaveChangesAsync(cancellationToken);
                return request.Hotel;
            }
        }
    }
}